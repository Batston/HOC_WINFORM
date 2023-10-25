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
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add(txtTenMon.Text);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (lstLuaChon.Items.Contains(lstDanhSach.SelectedItem))
            {
                    MessageBox.Show("Môn đã chọn!", "Thông báo");
            }
            else if (lstDanhSach.SelectedItem != null)
            {
                lstLuaChon.Items.Add(lstDanhSach.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn!", "Thông báo");
            }
        }

        private void btnBo_Click(object sender, EventArgs e)
        {
            if (lstLuaChon.SelectedItem != null)
            {
                lstLuaChon.Items.Remove(lstLuaChon.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn!", "Thông báo");
            }
        }

        private void btnChonHet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                if (lstLuaChon.Items.Contains(lstDanhSach.Items[i]))
                {
                    //do nothing
                }
                else
                {
                    lstLuaChon.Items.Add(lstDanhSach.Items[i]);
                }
            }
        }

        private void btnBoHet_Click(object sender, EventArgs e)
        {
            lstLuaChon.Items.Clear();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            txtChiTiet.Text = "Các môn đã chọn là: \r\n";
            for (int i = 0; i < lstLuaChon.Items.Count; i++)
            {
                txtChiTiet.Text = txtChiTiet.Text + "-" + lstLuaChon.Items[i] + "\r\n";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedItem != null)
            {
                lstDanhSach.Items.Remove(lstDanhSach.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn!", "Thông báo");
            }
        }
    }
}
