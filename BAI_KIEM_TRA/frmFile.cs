using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bai_Kiem_Tra
{
    public partial class frmFile : Form
    {
        public frmFile()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image | *.jpg, *.png;";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                picboxHienThi.Image = new Bitmap(ofd.FileName);
            }
        }

        private void frmFile_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChonNhieu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofds = new OpenFileDialog(); { ofds.Filter = "Image | *.jpg; *.png;"; }
            ofds.Multiselect = true;
            if(ofds.ShowDialog() == DialogResult.OK)
            {
               foreach ( var item in ofds.FileName)
                {
                  // FileInfo infor = new FileInfo(item);
                  // ListViewItem itemFile = new ListViewItem(infor.Name);
                  // int Size = int.Parse(infor.Length.ToString)/1024;
                  // string dungluong = Size.ToString() + "KB";
                  // itemFile.SubItem.Add(new ListViewItem.ListViewSubItem());
                  // { Text = infor.Length.ToString(); }
                  // listView1.Items.Add(itemFile);
                }
            }
        }
    }
}
