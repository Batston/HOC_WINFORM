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
    public partial class frmMain : Form
    {
        public String lop {get; set;}
        public String hoTen {get; set;}
        public String maSV {get; set;}

        public int Trai = 0;
        public int Phai = 0;
        public frmMain(String lop, String hoTen, String maSV)
        {
            InitializeComponent();
            this.lop = lop;
            this.hoTen = hoTen;
            this.maSV = maSV;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblLop.Text = lop;
            lblHoTen.Text = hoTen;
            lblMaSV.Text = maSV;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Trai += 2;
                lblTrai.Text = Trai.ToString();
            }
            else if (e.Button == MouseButtons.Right)
            {
                Phai += 2;
                lblPhai.Text = Phai.ToString();
            }
        }

        private void máyTínhĐơnGiảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMayTinhCoBan frmMayTinhCoBan = new frmMayTinhCoBan();
            frmMayTinhCoBan.ShowDialog();
            frmMayTinhCoBan = null;
            this.Show();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListBox frmListBox = new frmListBox();
            frmListBox.ShowDialog();
            frmListBox = null;
            this.Show();
        }

        private void formListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListView frmListView = new frmListView();
            frmListView.ShowDialog();
            frmListView = null;
            this.Show();
        }

        private void formRadioCheckBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRadioCheckBox frmRadioCheckBox = new frmRadioCheckBox();
            frmRadioCheckBox.ShowDialog();
            frmRadioCheckBox = null;
            this.Show();
        }
    }
}
