using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMaster
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();

            //Services List
            foreach (var key in AppProperties.Application.Services)
                Services.Items.Add((Service)key.Copy());

        }

        private void AddServiceBtn_Click(object sender, EventArgs e)
        {
            //Добавляем новый сервис
            ServiceEdit ServiceForm = new ServiceEdit();
            if (ServiceForm.ShowDialog() == DialogResult.OK)
            {
                foreach (Service key in Services.Items)
                    if (key.Name == ServiceForm.NameService && key.Host == ServiceForm.HostService && key.Port == ServiceForm.PortService)
                    {
                        MessageBox.Show("Упс, похоже, сервис такой уже есть.");
                        return;
                    }
                Services.Items.Add(new Service(ServiceForm.NameService, ServiceForm.HostService, ServiceForm.PortService));
            }
        }

        private void DeleteServiceBtn_Click(object sender, EventArgs e)
        {
            //Удаляем выделенный сервис
            if (Services.SelectedItem != null)
            {
                Int32 SelectedIndex = Services.SelectedIndex;

                //ПОСЛЕ КНОПКИ ОКЕЙ
                foreach (Sender key in ((Service)Services.SelectedItem).Senders)
                    AppProperties.Application.DefaultSenders.Remove(key);

                Services.Items.RemoveAt(Services.SelectedIndex);

                if (Services.Items.Count > 0)
                {
                    SelectedIndex = SelectedIndex > Services.Items.Count - 1 ? Services.Items.Count - 1 : SelectedIndex;
                    Services.SelectedIndex = SelectedIndex;
                }
            }
        }

        private void Services_DoubleClick(object sender, EventArgs e)
        {
            //Изменяем выделенный сервис
            if(Services.SelectedItem != null)
            {
                ServiceEdit ServiceForm = new ServiceEdit((Service)Services.SelectedItem);
                if(ServiceForm.ShowDialog() == DialogResult.OK)
                {
                    foreach (Service key in Services.Items)
                        if (key.Name == ServiceForm.NameService && key.Host == ServiceForm.HostService && key.Port == ServiceForm.PortService)
                        {
                            MessageBox.Show("Упс, похоже, такой сервис уже есть.");
                            return;
                        }
                    Services.Items[Services.SelectedIndex] = new Service(ServiceForm.NameService, ServiceForm.HostService, ServiceForm.PortService);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //Обновление общего списка сервисов
            AppProperties.Application.Services.Clear();

            foreach (Service key in Services.Items)
            {
                AppProperties.Application.Services.Add(key);
            }

            DialogResult = DialogResult.OK;
        }

        private void AddSenderBtn_Click(object sender, EventArgs e)
        {
            //Добавление ящика
            if (Services.SelectedItem != null)
            {
                SenderEdit SenderForm = new SenderEdit();
                if (SenderForm.ShowDialog() == DialogResult.OK)
                {
                    //Добавление
                    if (((Service)Services.SelectedItem).AddSender(SenderForm.LoginSender, SenderForm.PasswdSender))
                        Senders.Items.Add(((Service)Services.SelectedItem).Senders.Last());
                    else
                    {
                        MessageBox.Show("Похоже, что такой ящик у сервиса есть.");
                        return;
                    }
                }
            }
        }

        private void DeleteSenderBtn_Click(object sender, EventArgs e)
        {
            //Удаление ящика
            if (Senders.SelectedItem != null)
            {
                Int32 SelectedIndex = Senders.SelectedIndex;

                //Удалять только после нажатия кнопки окей!
                AppProperties.Application.DefaultSenders.Remove((Sender)Senders.SelectedItem);

                ((Service)Services.SelectedItem).Senders.Remove((Sender)Senders.SelectedItem);
                Senders.Items.RemoveAt(Senders.SelectedIndex);
                

                if (Senders.Items.Count > 0)
                {
                    SelectedIndex = SelectedIndex > Senders.Items.Count - 1 ? Senders.Items.Count - 1 : SelectedIndex;
                    Senders.SelectedIndex = SelectedIndex;
                }
            }
        }

        private void Senders_DoubleClick(object sender, EventArgs e)
        {
            //Только, если выбранный отправитель
            if (Senders.SelectedItem != null)
            {
                SenderEdit SenderForm = new SenderEdit((Sender)Senders.SelectedItem);

                if (SenderForm.ShowDialog() == DialogResult.OK)
                {
                    //Изменение
                    if (((Service)Services.SelectedItem).DoesSenderExist(SenderForm.LoginSender))
                    {
                        MessageBox.Show("Похоже, что такой ящик у сервиса есть.");
                        return;
                    }

                    //Меняем 
                    ((Sender)Senders.SelectedItem).Login = SenderForm.LoginSender;
                    ((Sender)Senders.SelectedItem).Passwd = SenderForm.PasswdSender;
                    Senders.Items[Senders.SelectedIndex] = Senders.SelectedItem;
                }
            }
        }

        private void Services_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReFillSenders();
        }

        private void ReFillSenders()
        {
            Senders.Items.Clear();
            if (Services.SelectedItem != null)
            {
                foreach (var key in ((Service)Services.SelectedItem).Senders)
                    Senders.Items.Add(key);
            }
        }


    }
}
