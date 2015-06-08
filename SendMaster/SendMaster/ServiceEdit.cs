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
    public partial class ServiceEdit : Form
    {
        Boolean Edited;
        public ServiceEdit()
        {
            InitializeComponent();
        }

        public ServiceEdit(Service Service)
        {
            InitializeComponent();

            NameService = Service.Name;
            HostService = Service.Host;
            PortService = Service.Port;

            Edited = false;
        }

        public String NameService
        {
            get { return NameServiceT.Text; }
            set { NameServiceT.Text = value; }
        }

        public String HostService
        {
            get { return HostServiceT.Text; }
            set { HostServiceT.Text = value; }
        }

        public Int32 PortService
        {
            get { return (int)PortServiceT.Value; }
            set { PortServiceT.Value = value; }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = Edited? DialogResult.OK : DialogResult.Cancel;
        }

        private void NameServiceT_TextChanged(object sender, EventArgs e)
        {
            Edited = true;
        }

        private void HostServiceT_TextChanged(object sender, EventArgs e)
        {
            Edited = true;
        }

        private void PortServiceT_ValueChanged(object sender, EventArgs e)
        {
            Edited = true;
        }
    }
}
