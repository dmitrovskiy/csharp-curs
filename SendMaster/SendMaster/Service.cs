using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMaster
{
    //Класс, представляющий коннект к серваку
    [Serializable]
    public class Service : ICopy
    {
        public String Host { get; set; }
        public Int32 Port { get; set; }
        public String Name { get; set; }
        public List<Sender> Senders;

        public Service(String Name, String Host, Int32 Port)
        {
            this.Name = Name;
            this.Host = Host;
            this.Port = Port;

            Senders = new List<Sender>();
        }

        //False- если такой уже есть
        public Boolean AddSender(String SenderLogin, String SenderPasswd)
        {
            if (DoesSenderExist(SenderLogin))
                return false;

            Senders.Add(new Sender(SenderLogin, SenderPasswd, this));
            return true;
        }

        public Boolean DoesSenderExist(String SenderLogin)
        {
            foreach (var key in Senders)
                if (key.Login == SenderLogin)
                    return true;
            return false;
        }

        public override string ToString()
        {
            return Name;
        }

        public object Copy()
        {
            Service Result = (Service) this.MemberwiseClone();

            Result.Senders = new List<Sender>();

            foreach (var key in Senders)
                Result.Senders.Add((Sender)key.Copy());

            return Result;
        }
    }
}
