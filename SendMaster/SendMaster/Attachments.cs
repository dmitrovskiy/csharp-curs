using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMaster
{
    public partial class Attachments : Form
    {
        MessageService MS;

        public Attachments(MessageService MS)
        {
            InitializeComponent();

            this.MS = MS;

            ImageList imList = new ImageList();
            imList.Images.Add(Properties.Resources.attach_document);

            listView1.SmallImageList = imList;
            listView1.LargeImageList = imList;

            FillFields();
        }

        private void FillFields()
        {
            foreach (var key in MS.Mail.Attachments)
            {
                ListViewItem Templvi = new ListViewItem(new FileInfo(key).Name, 0);
                Templvi.Tag = key;

                listView1.Items.Add(Templvi);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ListViewItem Templvi = new ListViewItem(new FileInfo(openFileDialog1.FileName).Name, 0);
                Templvi.Tag = openFileDialog1.FileName;

                listView1.Items.Add(Templvi);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem key in listView1.SelectedItems)
                    listView1.Items.Remove(key);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            MS.Mail.Attachments.Clear();
            foreach (ListViewItem key in listView1.Items)
                MS.Mail.Attachments.Add((String)key.Tag);

            DialogResult = DialogResult.OK;
        }
    }
}
