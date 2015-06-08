using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMaster
{
    [Serializable]
    public struct SendMailResult
    {
        public bool IsSent { get; set; }
        public Exception Error { get; set; }

        public override string ToString()
        {
            String Result = "";
            if (Error == null)
            {
                Result += "Письма успешно отосланы нескольким адресатам.";
            }
            else
            {
                Result += "При отправке произошла ошибка : " + Error.Message;
            }

            return Result;
        }
    }
}
