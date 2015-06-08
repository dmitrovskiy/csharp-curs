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
    public partial class DistAddresses : Form
    {
        MessageService MS;

        public DistAddresses(MessageService MS)
        {
            InitializeComponent();

            this.MS = MS;

            FillListBoxes();
            CheckNextBtn();
        }

        private void FillListBoxes()
        {
            foreach (var key in MS.Addresses)
                SendAddr.Items.Add(key);

            foreach (var key in AppProperties.Application.Mails)
                if (!SendAddr.Items.Contains(key))
                    AllAddr.Items.Add(key);
        }

        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            Int32 SelectedIndex = AllAddr.SelectedIndex;

            AllAddr_DoubleClick(this, EventArgs.Empty);

            if (SelectedIndex != -1 && AllAddr.Items.Count > 0)
            {
                SelectedIndex = SelectedIndex > AllAddr.Items.Count - 1 ? AllAddr.Items.Count - 1 : SelectedIndex;
                AllAddr.SelectedIndex = SelectedIndex;
            }
        }

        private void BackwardBtn_Click(object sender, EventArgs e)
        {
            Int32 SelectedIndex = SendAddr.SelectedIndex;

            SendAddr_DoubleClick(this, EventArgs.Empty);

            if (SelectedIndex != -1 && SendAddr.Items.Count > 0)
            {
                SelectedIndex = SelectedIndex > SendAddr.Items.Count - 1 ? SendAddr.Items.Count - 1 : SelectedIndex;
                SendAddr.SelectedIndex = SelectedIndex;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MailEdit ME = new MailEdit();
            if (ME.ShowDialog() == DialogResult.OK)
            {
                if (AppProperties.Application.Mails.Contains(ME.Addr))
                    MessageBox.Show("Упс, похоже, что такой адрес уже есть.");
                else
                {
                    AppProperties.Application.Mails.Add(ME.Addr);
                    AllAddr.Items.Add(ME.Addr);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (AllAddr.SelectedItem != null)
            {
                AppProperties.Application.Mails.Remove((String)AllAddr.SelectedItem);
                AllAddr.Items.Remove(AllAddr.SelectedItem);
            }
        }

        private void AllAddr_DoubleClick(object sender, EventArgs e)
        {
            if (AllAddr.SelectedItem != null)
            {
                SendAddr.Items.Add(AllAddr.SelectedItem);
                AllAddr.Items.RemoveAt(AllAddr.SelectedIndex);

                CheckNextBtn();
            }
        }

        private void SendAddr_DoubleClick(object sender, EventArgs e)
        {
            if (SendAddr.SelectedItem != null)
            {
                AllAddr.Items.Add(SendAddr.SelectedItem);
                SendAddr.Items.RemoveAt(SendAddr.SelectedIndex);

                CheckNextBtn();
            }
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
            this.Hide();
            FillMessageService();
            if (new DistMessage(MS).ShowDialog() == DialogResult.No)
                this.Show();
            else
                DialogResult = DialogResult.OK;
        }

        private void FillMessageService()
        {
            MS.Addresses.Clear();
            foreach (String key in SendAddr.Items)
                MS.Addresses.Add(key);
        }

        private void CheckNextBtn()
        {
            if (SendAddr.Items.Count > 0)
                NextBtn.Enabled = true;
            else
                NextBtn.Enabled = false;
        }
    }
}
