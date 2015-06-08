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
    public partial class SenderEdit : Form
    {
        Boolean Edited = false;
        public SenderEdit()
        {
            InitializeComponent();
        }

        public SenderEdit(Sender sender)
        {
            InitializeComponent();
            LoginSender = sender.Login;
            PasswdSender = sender.Passwd;

            Edited = false;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = Edited? DialogResult.OK : DialogResult.Cancel;
        }

        public String LoginSender
        {
            get { return NameT.Text; }
            set { NameT.Text = value; }
        }

        public String PasswdSender
        {
            get { return PasswdT.Text; }
            set { PasswdT.Text = value; }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void PasswdT_TextChanged(object sender, EventArgs e)
        {
            Edited = true;
        }

        private void NameT_TextChanged(object sender, EventArgs e)
        {
            Edited = true;
        }
    }
}
