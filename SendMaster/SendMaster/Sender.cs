using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMaster
{
    [Serializable]
    public class Sender : ICopy
    {
        public static Sender Empty = new Sender("", "", null);

        public String Login { get; set; }
        public String Passwd { get; set; }
        public Service Service { get; set; }

        public Sender(String Login, String Passwd, Service Service)
        {
            this.Login = Login;
            this.Passwd = Passwd;
            this.Service = Service;
        }

        public override string ToString()
        {
            return Login;
        }

        public object Copy()
        {
            return this.MemberwiseClone();
        }

        public static bool operator == (Sender One, Sender Two)
        {
            if (One == null && Two == null)
                return true;
            else if (One == null || Two == null)
                return false;

            return One.Equals(Two);
        }

        public static bool operator !=(Sender one, Sender two)
        {
            return !one.Equals(two);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Sender p = obj as Sender;
            if ((object)p == null)
                return false;

            return this.Login == p.Login && this.Passwd == p.Passwd;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
