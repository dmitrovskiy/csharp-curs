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
    public partial class SendMessageHistory : Form
    {
        public SendMessageHistory()
        {
            InitializeComponent();

            FillHistory();
        }

        private void FillHistory()
        {
            HistoryView.Items.Clear();

            HistoryView.FullRowSelect = true;
            HistoryView.Columns.Add("№",-2,HorizontalAlignment.Left);
            HistoryView.Columns.Add("Тема рассылки", -2, HorizontalAlignment.Left);
            HistoryView.Columns.Add("Содержание", -2, HorizontalAlignment.Left);
            HistoryView.Columns.Add("Дата завершения", -2, HorizontalAlignment.Left);

            for (int i = 0; i < AppProperties.Application.HistoryMails.Count; i++)
            {
                ListViewItem tempLvi = new ListViewItem((i+1).ToString());
                //Тема
                tempLvi.SubItems.Add(new ListViewItem.ListViewSubItem(tempLvi, AppProperties.Application.HistoryMails[i].Mail.Subject));
                //Содержание
                tempLvi.SubItems.Add(new ListViewItem.ListViewSubItem(tempLvi, AppProperties.Application.HistoryMails[i].Mail.Body));
                //Дата
                tempLvi.SubItems.Add(new ListViewItem.ListViewSubItem(tempLvi, AppProperties.Application.HistoryMails[i].DateCompleted.ToShortDateString()));
                //Основной обьект
                tempLvi.Tag = AppProperties.Application.HistoryMails[i];

                HistoryView.Items.Add(tempLvi);
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (HistoryView.SelectedItems.Count > 0)
            {
                this.Hide();
                //Реализовать копию
                new DistServices((MessageService)((MessageService)HistoryView.SelectedItems[0].Tag).Copy()).ShowDialog();
                FillHistory();
                this.Show();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            AppProperties.Application.HistoryMails.Clear();

            foreach (ListViewItem key in HistoryView.Items)
                AppProperties.Application.HistoryMails.Add((MessageService)key.Tag);

            DialogResult = DialogResult.OK;
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (HistoryView.SelectedItems.Count > 0)
                foreach (ListViewItem key in HistoryView.SelectedItems)
                    HistoryView.Items.Remove(key);
        }

        private void DeleteAllBtn_Click(object sender, EventArgs e)
        {
            HistoryView.Items.Clear();
        }
    }
}
