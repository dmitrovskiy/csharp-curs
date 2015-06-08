using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendMaster
{
    [Serializable]
    public class SerializableMailMessage : ICopy
    {
        public String Subject { get; set; }
        public String Body { get; set; }
        public Boolean IsHtml { get; set; }
        public List<String> Attachments { get; set; }

        public SerializableMailMessage()
        {
            Attachments = new List<string>();
        }

        public MailMessage GetMailMessage()
        {
            MailMessage Result = new MailMessage() { Subject = this.Subject, Body = this.Body, IsBodyHtml = this.IsHtml };

            foreach (var key in Attachments)
                Result.Attachments.Add(new Attachment(key));

            return Result;
        }

        public object Copy()
        {
            SerializableMailMessage ResultCopy = (SerializableMailMessage)MemberwiseClone();

            ResultCopy.Attachments = new List<string>();
            ResultCopy.Attachments.AddRange(this.Attachments);

            return ResultCopy;                
        }
    }
}
