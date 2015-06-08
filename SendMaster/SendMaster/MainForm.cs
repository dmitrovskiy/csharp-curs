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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ServicesBtn_Click(object sender, EventArgs e)
        {
            new ServicesForm().ShowDialog();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            new DistServices().ShowDialog();
        }

        private void ToolStripBtn_Click(object sender, EventArgs e)
        {
            new AppSettings().ShowDialog();
        }

        private void SendHistoryBtn_Click(object sender, EventArgs e)
        {
            new SendMessageHistory().ShowDialog();
        }
    }
}
