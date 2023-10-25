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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }
        int maSV = 0;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                ListViewItem lvi = new ListViewItem("SV" + ++maSV);
                lvi.SubItems.Add(txtHoTen.Text);
                lvi.SubItems.Add(txtEmail.Text);
                lvi.SubItems.Add(cbxGioiTinh.Text);
                lvi.SubItems.Add((txtNgaySinh.Text).ToString());
                lvw.Items.Add(lvi);
            }
        }

        private void lvw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lvw.Items.Remove(lvw.SelectedItems[0]);
        }

        private void lvw_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = lvw.SelectedItems[0].SubItems[1].Text;
            txtEmail.Text = lvw.SelectedItems[0].SubItems[2].Text;
            cbxGioiTinh.Text = lvw.SelectedItems[0].SubItems[3].Text;
            txtNgaySinh.Text = lvw.SelectedItems[0].SubItems[4].Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lvw.SelectedItems[0].SubItems[1].Text = txtHoTen.Text;
            lvw.SelectedItems[0].SubItems[2].Text = txtEmail.Text;
            lvw.SelectedItems[0].SubItems[3].Text = cbxGioiTinh .Text;
            lvw.SelectedItems[0].SubItems[4].Text = txtNgaySinh.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString() +" - " + DateTime.Now.ToShortDateString();
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtHoTen.Text))
            {
                txtHoTen.Focus();
                errorProvider1.SetError(txtHoTen, "Vui long nhap ho ten!");
            }
            else
            {
                errorProvider1.SetError(txtHoTen, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                errorProvider2.SetError(txtEmail, "Vui long nhap Email!");
            }
            else
            {
                errorProvider2.SetError(txtEmail, null);
            }
        }

        private void cbxGioiTinh_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cbxGioiTinh.Text))
            {
                cbxGioiTinh.Focus();
                errorProvider3.SetError(cbxGioiTinh, "Vui long chon gioi tinh!");
            }
            else
            {
                errorProvider3.SetError(cbxGioiTinh, null);
            }
        }

        private void txtNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNgaySinh.Text))
            {
                txtNgaySinh.Focus();
                errorProvider4.SetError(txtNgaySinh, "Vui long nhap ho ten!");
            }
            else
            {
                errorProvider4.SetError(txtNgaySinh, null);
            }
        }

    }
}
