using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Kiem_Tra
{
    public partial class frmFileListView : Form
    {
        string path;
        string tenFile;
        public frmFileListView()
        {
            InitializeComponent();
        }
        List<SinhVien> dssv = new List<SinhVien>();
        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Notepad | *.txt;" };
            if(ofd)
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaSV.Text != "" && txtHoTen.Text != "" && txtDiaChi.Text != "" && cbxGioiTinh.Text != "")
            {
                SinhVien sv = new SinhVien();
                sv.maSV = txtMaSV.Text;
                sv.hoTen = txtHoTen.Text;
                sv.gioiTinh = cbxGioiTinh.Text;
                sv.diaChi = txtDiaChi.Text;

                dssv.Add(sv);

               // HienThiLenListView();
            }
            else
            {
                MessageBox.Show("Có lỗi", "Thông báo");
            }
        }
    }
}
