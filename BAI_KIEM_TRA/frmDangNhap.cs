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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (cbxChonLop.Text == "21CT114" && txtTenDangNhap.Text == "Vu Minh Phuong" && txtMatKhau.Text == "121001175")
                {
                    if (MessageBox.Show("Đã đủ điều kiện làm bài kiểm tra!", "Thành công") == DialogResult.OK) ;
                    {
                        this.Hide();
                        frmMain frmMain = new frmMain(cbxChonLop.Text, txtTenDangNhap.Text, txtMatKhau.Text);
                        frmMain.Show();
                    }
                }
            }
        }

        private void cbxChonLop_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(cbxChonLop.Text))
            {
                e.Cancel = true;
                cbxChonLop.Focus();
                errorProvider1.SetError(cbxChonLop, "Vui long chon lop cua ban!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbxChonLop, null);
            }
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                e.Cancel = true;
                txtTenDangNhap.Focus();
                errorProvider2.SetError(txtTenDangNhap, "Vui long nhap ten cua ban!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtTenDangNhap, null);
            }
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtMatKhau.Text))
            {
                e.Cancel = true;
                txtMatKhau.Focus();
                errorProvider3.SetError(txtMatKhau, "Vui long nhap mat khau!");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(txtMatKhau, null);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
             Close(); 
            }
        }
    }
}
