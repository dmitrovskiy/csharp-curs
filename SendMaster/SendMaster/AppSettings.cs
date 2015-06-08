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
    public partial class AppSettings : Form
    {
        public AppSettings()
        {
            InitializeComponent();

            FillFields();
        }

        private void FillFields()
        {
            //Установка
            TimeSendIntervalN.Value = AppProperties.Application.TimeSendInterval;
            CountPerSendN.Value = AppProperties.Application.CountPerSend;
            if (AppProperties.Application.IsHtml)
                IsHTMLBodyR.Checked = true;
            else
                IsSIMPLYBodyR.Checked = true;

            foreach (var key in AppProperties.Application.GetAllSenders())
                if(!AppProperties.Application.DefaultSenders.Contains(key))
                    AllSenders.Items.Add(key);
            foreach (var key in AppProperties.Application.DefaultSenders)
                DefaultSenders.Items.Add(key);

            switch (AppProperties.Application.DefaultDist)
            {
                case DistributionType.Sequence:
                    DistTypeCom.SelectedIndex = 0;
                    break;
                case DistributionType.Random:
                    DistTypeCom.SelectedIndex = 1;
                    break;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            AppProperties.Application.TimeSendInterval = (Int32)TimeSendIntervalN.Value;
            AppProperties.Application.CountPerSend = (Int32)CountPerSendN.Value;
            AppProperties.Application.IsHtml = IsSIMPLYBodyR.Checked ? true : false;

            AppProperties.Application.DefaultSenders.Clear();
            foreach (Sender key in DefaultSenders.Items)
                AppProperties.Application.DefaultSenders.Add(key);

            switch (DistTypeCom.SelectedIndex)
            {
                case 0:
                    AppProperties.Application.DefaultDist = DistributionType.Sequence;
                    break;
                case 1:
                    AppProperties.Application.DefaultDist = DistributionType.Random;
                    break;
            }
            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AllSenders_DoubleClick(object sender, EventArgs e)
        {
            if (AllSenders.SelectedItem != null)
            {
                DefaultSenders.Items.Add(AllSenders.SelectedItem);
                AllSenders.Items.RemoveAt(AllSenders.SelectedIndex);
            }
        }

        private void DefaultSenders_DoubleClick(object sender, EventArgs e)
        {
            if (DefaultSenders.SelectedItem != null)
            {
                AllSenders.Items.Add(DefaultSenders.SelectedItem);
                DefaultSenders.Items.RemoveAt(DefaultSenders.SelectedIndex);
            }
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Int32 SelectedIndex = DefaultSenders.SelectedIndex;

            DefaultSenders_DoubleClick(this, EventArgs.Empty);

            if (SelectedIndex != -1 && DefaultSenders.Items.Count > 0)
            {
                SelectedIndex = SelectedIndex > DefaultSenders.Items.Count - 1 ? DefaultSenders.Items.Count - 1 : SelectedIndex;

                DefaultSenders.SelectedIndex = SelectedIndex;
            }
        }
    }
}
