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
    public delegate void setControlValue(object control, object value);

    public partial class SendProcess : Form
    {
        setControlValue setLogTextBox;
        setControlValue setProgressVal;
        setControlValue setLabelState;
        setControlValue setButtonEnabled;

        MessageService MS;
        public SendProcess(MessageService MS)
        {
            InitializeComponent();

            setLogTextBox = (x, y) => ((TextBox)x).Text += "   -   " + y.ToString() + Environment.NewLine;
            setProgressVal = (x, y) => ((ProgressBar)x).PerformStep();
            setLabelState = (x, y) => {
                Label ltemp = (Label)x;
                if((Boolean)y)
                {
                    ltemp.Text = "Рассылка завершена!";
                    ltemp.ForeColor = Color.DodgerBlue;
                }
                else
                {
                    ltemp.Text = String.Format("Приблизительное время : {0} сек.", Math.Round((decimal)(MS.TimeSendInterval * (MS.Addresses.Count / MS.CountPerSend)) / 100));
                    ltemp.ForeColor = Color.Black;
                }
            };
        setButtonEnabled = (x, y) => ((Button)x).Enabled = (Boolean)y;


            this.MS = MS;

            progressBar1.Value = 0;
            progressBar1.Maximum = MS.Addresses.Count;
            progressBar1.Step = MS.CountPerSend;

            MS.MessageSent += MS_MessageSent;

            CheckEndSend();
            MS.StartSend();
        }

        private void CheckEndSend()
        {
            if (MS.IsCompleted)
            {
                setLabelState(CommonState, true);
                setButtonEnabled(OkBtn, true);
            }
            else
            {
                setLabelState(CommonState, false);
                setButtonEnabled(OkBtn, false);
            }
        }

        void MS_MessageSent(object obj, SendMailResult e)
        {
            //Лейбл и кнопка завершения
            if (MS.IsCompleted)
            {
                CommonState.Invoke(setLabelState, CommonState, true);
                OkBtn.Invoke(setButtonEnabled, OkBtn, true);
            }
            else
            {
                CommonState.Invoke(setLabelState, CommonState, false);
                OkBtn.Invoke(setButtonEnabled, OkBtn, false);
            }

            if (e.Error == null)
                progressBar1.Invoke(setProgressVal, progressBar1, null);

            Log.Invoke(setLogTextBox, Log, e);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            //Завершение отправки
            CompleteSendProcess();
            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Уверены в отмене рассылки?", "Отмена?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //Прикращение отправки
                MS.StopSend();
                //Завершение отправки
                CompleteSendProcess();
                DialogResult = DialogResult.Cancel;
            }
        }

        private void CompleteSendProcess()
        {
            //Отписка от события(Для нормальной серриализации)
            MS.MessageSent -= MS_MessageSent;
            //В историю
            AppProperties.Application.HistoryMails.Add(MS);
        }
    }
}
