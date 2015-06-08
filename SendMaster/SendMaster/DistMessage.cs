using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMaster
{
    public partial class DistMessage : Form
    {
        MessageService MS;

        public DistMessage(MessageService MS)
        {
            InitializeComponent();
            this.MS = MS;

            ValidateAttachment();

            FillFields();
        }

        private void ValidateAttachment()
        {
            List<String> DeleteList = new List<String>();
            //Проверка
            foreach (var key in MS.Mail.Attachments)
            {
                if (!File.Exists(key))
                {
                    MessageBox.Show(String.Format("Похоже, что файла {0} больше не существует.", key), "Вложения");
                    DeleteList.Add(key);
                }
            }
            //Удаление
            foreach (var key in DeleteList)
                MS.Mail.Attachments.Remove(key);
        }


        private void FillFields()
        {
            SubjectT.Text = MS.Mail.Subject;
            BodyT.Text = MS.Mail.Body;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            //Need for update
            MS.Mail.Subject = SubjectT.Text;
            MS.Mail.Body = BodyT.Text;

            this.Hide();
            new SendProcess(MS).ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void AttBtn_Click(object sender, EventArgs e)
        {
            new Attachments(MS).ShowDialog();
        }
    }
}
