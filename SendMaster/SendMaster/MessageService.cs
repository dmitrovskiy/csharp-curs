using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.ComponentModel;
using System.Net;
using System.Threading;

namespace SendMaster
{
    public delegate void SentDelegate(object obj, SendMailResult e);

    [Serializable]
    public abstract class MessageService : ICopy
    {
        public abstract event SentDelegate MessageSent;

        //Курсор для списка отправителей
        protected Int32 AddressesIndex;
        //Для возобнавления и контроля рассылки
        protected Boolean ThreadEnd { get; set; }
        //Дата завершения рассылки
        public DateTime DateCompleted { get; set; }
        
        //Коллекция отправителей
        public List<Sender> Senders { get; set; }
        //Коллекция адресатов
        public List<String> Addresses { get; set; }
        //Серриализуемый обьект сообщения
        public SerializableMailMessage Mail;

        //Сообщение
        [NonSerialized]
        protected MailMessage Msg;
        [NonSerialized]
        protected SmtpClient SendClient;
        //Рабочий поток
        [NonSerialized]
        protected Thread DistThread;

        public int TimeSendInterval = AppProperties.Application.TimeSendInterval;//3000 miliseconds
        public int CountPerSend = AppProperties.Application.CountPerSend;//1 mail per send interval

        //История отправки в UserState само сообщение
        public List<SendMailResult> HistorySend { get; set; }

        public virtual Boolean IsCompleted
        {
            get
            {
                return AddressesIndex >= Addresses.Count;
            }
        }

        public virtual void StartSend()
        {
            //подготовка к отправке
            PrepareSend();

            //Запуск потока
            DistThread = new Thread(new ThreadStart(SendThread));
            DistThread.Start();
        }

        public virtual void StopSend()
        {
            //Останавливем поток
            CompleteSend();
        }

        protected abstract void SendThread();

        protected virtual void CompleteSend()
        {
            ThreadEnd = true;
            AddressesIndex = 0;
            DateCompleted = DateTime.Now;
        }

        protected virtual void PrepareSend()
        {
            //Подготовка индексикатора
            AddressesIndex = 0;
            //Очистка сообщений
            HistorySend.Clear();
            ThreadEnd = false;
            //Создание сообщения
            Msg = Mail.GetMailMessage();
        }

        //Constructor
        public MessageService()
        {
            Mail = new SerializableMailMessage();

            ThreadEnd = false;
            this.Senders = new List<Sender>();
            this.Addresses = new List<string>();
            this.HistorySend = new List<SendMailResult>();
        }

        public object Copy()
        {
            MessageService Result = (MessageService)this.MemberwiseClone();

            Result.DistThread = null;

            Result.Senders = new List<Sender>();
            Result.Senders.AddRange(this.Senders);

            Result.Addresses = new List<string>();
            Result.Addresses.AddRange(this.Addresses);

            Result.Mail = (SerializableMailMessage)this.Mail.Copy();

            return Result;
        }
    }

    [Serializable]
    public class MessageRandomService : MessageService
    {
        //Событие отправки сообщений
        public override event SentDelegate MessageSent;

        int CurrentSender = 0;

        public MessageRandomService() { }

        Random rand = new Random();

        public override Boolean IsCompleted
        {
            get
            {
                return Senders.Count == 0 || base.IsCompleted;
            }
        }

        protected override void SendThread()
        {
            while (!IsCompleted && !ThreadEnd)
            {
                //Sender
                CurrentSender = rand.Next(0, Senders.Count);
                //SMTP
                SendClient = new SmtpClient(Senders[CurrentSender].Service.Host, Senders[CurrentSender].Service.Port);

                SendClient.UseDefaultCredentials = false;
                SendClient.Credentials = new NetworkCredential(Senders[CurrentSender].Login, Senders[CurrentSender].Passwd);
                SendClient.EnableSsl = true;

                //Формируем MSG
                Msg.To.Clear();

                StringBuilder toAddresses = new StringBuilder();
                for (int i = AddressesIndex, j = 0; i < Addresses.Count && j < CountPerSend; i++, j++)
                {
                    if (i == AddressesIndex)
                        toAddresses.Append(Addresses[i]);
                    else
                        toAddresses.Append(',' + Addresses[i]);
                }

                Msg.To.Add(toAddresses.ToString());

                Msg.From = new MailAddress(Senders[CurrentSender].Login);

                Msg.IsBodyHtml = AppProperties.Application.IsHtml;

                SendMailResult TempSm;
                //Отправка
                try
                {
                    SendClient.Send(Msg);

                    TempSm = new SendMailResult() { IsSent = true };

                    //Шлем следующим адресатам
                    AddressesIndex += CountPerSend;
                    //Addresses.RemoveRange(0, CountPerSend < Addresses.Count ? CountPerSend : Addresses.Count);
                    
                }
                catch (Exception e)
                {
                    TempSm = new SendMailResult() { Error = e, IsSent = false };

                    Senders.RemoveAt(CurrentSender);
                }

                if (MessageSent != null)
                    MessageSent(this, TempSm);

                this.HistorySend.Add(TempSm);
            }

            CompleteSend();
        }
    }

    [Serializable]
    public class MessageSequenceService : MessageService
    {
        //Событие отправки сообщений
        public override event SentDelegate MessageSent;

        int CurrentSender = 0;

        public MessageSequenceService() { }

        public override Boolean IsCompleted
        {
            get
            {
                return Senders.Count == 0 || base.IsCompleted;
            }
        }

        protected override void SendThread()
        {
            while (!IsCompleted && !ThreadEnd)
            {
                //Sender
                CurrentSender = CurrentSender == Senders.Count - 1 ? 0 : CurrentSender + 1;
                //SMTP
                SendClient = new SmtpClient(Senders[CurrentSender].Service.Host, Senders[CurrentSender].Service.Port);

                SendClient.UseDefaultCredentials = false;
                SendClient.Credentials = new NetworkCredential(Senders[CurrentSender].Login, Senders[CurrentSender].Passwd);
                SendClient.EnableSsl = true;

                //Формируем MSG
                Msg.To.Clear();

                StringBuilder toAddresses = new StringBuilder();
                for (int i = AddressesIndex, j = 0; i < Addresses.Count && j < CountPerSend; i++, j++)
                {
                    if (i == AddressesIndex)
                        toAddresses.Append(Addresses[i]);
                    else
                        toAddresses.Append(',' + Addresses[i]);
                }

                Msg.To.Add(toAddresses.ToString());

                Msg.From = new MailAddress(Senders[CurrentSender].Login);

                Msg.IsBodyHtml = AppProperties.Application.IsHtml;

                SendMailResult TempSm;
                //Отправка
                try
                {
                    SendClient.Send(Msg);

                    TempSm = new SendMailResult() { IsSent = true };

                    //Шлем следующим адресатам
                    AddressesIndex += CountPerSend;
                    //Addresses.RemoveRange(0, CountPerSend < Addresses.Count ? CountPerSend : Addresses.Count);

                }
                catch (Exception e)
                {
                    TempSm = new SendMailResult() { Error = e, IsSent = false };
                    //Убираем юзера, от которого не можем отослать сообщение
                    Senders.RemoveAt(CurrentSender);
                }

                if (MessageSent != null)
                    MessageSent(this, TempSm);

                this.HistorySend.Add(TempSm);
            }

            CompleteSend();
        }
    }
}
