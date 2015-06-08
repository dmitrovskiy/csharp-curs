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
    public partial class MailEdit : Form
    {
        Boolean Edited = false;
        public MailEdit()
        {
            InitializeComponent();
        }

        public MailEdit(String addr)
        {
            InitializeComponent();

            this.Addr = addr;

            Edited = false;
        }

        public String Addr
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Edited)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Edited = true;
        }
    }
}
