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
    public partial class frmMayTinhCoBan : Form
    {
        public frmMayTinhCoBan()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                txtKetQua.Text = (Int32.Parse(txtSoNhat.Text) + Int32.Parse(txtSoHai.Text)).ToString();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                txtKetQua.Text = (Int32.Parse(txtSoNhat.Text) - Int32.Parse(txtSoHai.Text)).ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                txtKetQua.Text = (Int32.Parse(txtSoNhat.Text) * Int32.Parse(txtSoHai.Text)).ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                txtKetQua.Text = (Int32.Parse(txtSoNhat.Text) / Int32.Parse(txtSoHai.Text)).ToString();
            }
        }

        private void txtSoNhat_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(txtSoNhat.Text))
            {
                e.Cancel = true;
                txtSoNhat.Focus();
                errorProvider1.SetError(txtSoNhat, "Vui long nhap so can tinh!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoNhat, null);
            }
        }

        private void txtSoHai_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSoHai.Text))
            {
                e.Cancel = true;
                txtSoHai.Focus();
                errorProvider2.SetError(txtSoHai, "Vui long nhap so can tinh!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtSoHai, null);
            }
        }
    }
}
