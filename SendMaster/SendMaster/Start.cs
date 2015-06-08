using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace SendMaster
{
    public partial class Start : Form
    {
        System.Windows.Forms.Timer timer;
        public Start()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += timer_Tick;

            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            AppProperties.CreateInstance();
            this.Hide();
            new MainForm().ShowDialog();
            AppProperties.Application.Save();
            this.Close();
        }
    }                      
}
