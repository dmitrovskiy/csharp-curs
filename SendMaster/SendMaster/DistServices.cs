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
    public partial class DistServices : Form
    {
        MessageService MS;

        public DistServices()
        {
            InitializeComponent();

            switch (AppProperties.Application.DefaultDist)
            {
                case DistributionType.Sequence:
                    MS = new MessageSequenceService();
                    break;
                default:
                    MS = new MessageRandomService();
                    break;
            }

            FillListBoxes();
            CheckNextBtn();
        }

        public DistServices(MessageService MS)
        {
            InitializeComponent();

            this.MS = MS;

            FillListBoxes();
            CheckNextBtn();
        }

        private void FillListBoxes()
        {
            if (MS.Senders.Count > 0)
            {
                foreach (var key in MS.Senders)
                    SendSenders.Items.Add(key);
            }
            else
            {
                foreach (var key in AppProperties.Application.DefaultSenders)
                    SendSenders.Items.Add(key);
            }

            foreach(var key in AppProperties.Application.GetAllSenders())
                if(!SendSenders.Items.Contains(key))
                    AllSenders.Items.Add(key);
        }

        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            Int32 SelectedIndex = AllSenders.SelectedIndex;

            AllSenders_DoubleClick(this, EventArgs.Empty);

            if (SelectedIndex != -1 && AllSenders.Items.Count > 0)
            {
                SelectedIndex = SelectedIndex > AllSenders.Items.Count - 1 ? AllSenders.Items.Count - 1 : SelectedIndex;
                AllSenders.SelectedIndex = SelectedIndex;
            }
        }

        private void BackwardBtn_Click(object sender, EventArgs e)
        {
            Int32 SelectedIndex = SendSenders.SelectedIndex;

            SendSenders_DoubleClick(this, EventArgs.Empty);

            if (SelectedIndex != -1 && SendSenders.Items.Count > 0)
            {
                SelectedIndex = SelectedIndex > SendSenders.Items.Count - 1 ? SendSenders.Items.Count - 1 : SelectedIndex;
                SendSenders.SelectedIndex = SelectedIndex;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FillMessageService();
            if (new DistAddresses(MS).ShowDialog() == DialogResult.No)
            {
                this.Show();
            }
            else
                DialogResult = DialogResult.OK;
        }

        private void FillMessageService()
        {
            MS.Senders.Clear();
            foreach (Sender key in SendSenders.Items)
                MS.Senders.Add(key);
        }

        private void CalcelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AllSenders_DoubleClick(object sender, EventArgs e)
        {
            if (AllSenders.SelectedItem != null)
            {
                SendSenders.Items.Add(AllSenders.SelectedItem);
                AllSenders.Items.RemoveAt(AllSenders.SelectedIndex);
                CheckNextBtn();
            }
        }

        private void SendSenders_DoubleClick(object sender, EventArgs e)
        {
            if (SendSenders.SelectedItem != null)
            {
                AllSenders.Items.Add(SendSenders.SelectedItem);
                SendSenders.Items.RemoveAt(SendSenders.SelectedIndex);
                CheckNextBtn();
            }
        }

        private void CheckNextBtn()
        {
            if (SendSenders.Items.Count > 0)
                NextBtn.Enabled = true;
            else
                NextBtn.Enabled = false;
        }
    }
}
