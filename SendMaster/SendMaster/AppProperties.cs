using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMaster
{
    public enum DistributionType{Sequence,Random};
    //Singleton
    public class AppProperties
    {
        private static AppProperties app;

        public List<String> Mails;
        public List<Service> Services;
        public List<Sender> DefaultSenders;
        public List<MessageService> HistoryMails;

        public int TimeSendInterval = 3000;//3000 miliseconds
        public int CountPerSend = 1;//1 mail per send interval
        public Boolean FirstOpen = true;
        public Boolean IsHtml = true;
        public DistributionType DefaultDist = DistributionType.Sequence;

        private AppProperties()
        {
            //Подгрузка настроек
            Stream FS = null;
            try
            {
                FS = File.Open("config.sm", FileMode.Open);

                //Дессериализация настроек
                BinaryFormatter bf = new BinaryFormatter();
                TimeSendInterval = (int)bf.Deserialize(FS);
                CountPerSend = (int)bf.Deserialize(FS);
                Mails = (List<String>)bf.Deserialize(FS);
                Services = (List<Service>)bf.Deserialize(FS);
                DefaultSenders = (List<Sender>)bf.Deserialize(FS);
                DefaultDist = (DistributionType)bf.Deserialize(FS);
                IsHtml = (Boolean)bf.Deserialize(FS);
                HistoryMails = (List<MessageService>)bf.Deserialize(FS);

                FS.Close();
                FirstOpen = false;
            }
            catch
            {
                Mails = new List<string>();
                Services = new List<Service>();
                DefaultSenders = new List<Sender>();
                HistoryMails = new List<MessageService>();
            }
            finally
            {
                if (FS != null)
                    FS.Close();
            }
        }

        public static void CreateInstance()
        {
            app = new AppProperties();
        }

        public void Save()
        {
            Stream FS = null;
            try
            {
                FS = File.OpenWrite("config.sm");

                //Серриализация
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(FS, TimeSendInterval);
                bf.Serialize(FS, CountPerSend);
                bf.Serialize(FS, Mails);
                bf.Serialize(FS, Services);
                bf.Serialize(FS, DefaultSenders);
                bf.Serialize(FS, DefaultDist);
                bf.Serialize(FS, IsHtml);
                bf.Serialize(FS, HistoryMails);

                FS.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally
            {
                if (FS != null)
                    FS.Close();
            }
        }

        public static AppProperties Application
        {
            get
            {
                if (app == null)
                    app = new AppProperties();
                return app;
            }
        }

        public List<Sender> GetAllSenders()
        {
            List<Sender> Result = new List<Sender>();

            foreach (var key in Services)
                Result.AddRange(key.Senders);

            return Result;
        }
    }
}
