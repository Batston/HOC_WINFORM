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
    public partial class frmRadioCheckBox : Form
    {
        public frmRadioCheckBox()
        {
            InitializeComponent();
        }

        private void rdoDo_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.ForeColor = Color.Red;
        }

        private void rdoTrang_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.ForeColor = Color.White;
        }

        private void rdoXanh_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.ForeColor = Color.Green;
        }

        private void cbxCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            cbxNgheNhac.Checked = true;
            cbxXemPhim.Checked = true;
            cbxGame.Checked = true;
            cbxLapTrinh.Checked = true;
            cbxDuLich.Checked = true;

            }

        private void btnTongHop_Click(object sender, EventArgs e)
        {
            txtTongHop.Text = "Sở thích của bạn:\r\n";
            if(cbxNgheNhac.Checked == true)
            {
                txtTongHop.Text = txtTongHop.Text + "-Nghe nhạc\r\t";
            }
            if(cbxXemPhim.Checked == true)
            {
                txtTongHop.Text = txtTongHop.Text + "-Xem Phim\r\t";
            }
            if(cbxGame.Checked == true)
            {
                txtTongHop.Text = txtTongHop.Text + "-Game\r\t";
            }
            if(cbxLapTrinh.Checked == true)
            {
                txtTongHop.Text = txtTongHop.Text + "-Lập trình\r\t";
            }
            if(cbxDuLich.Checked == true)
            {
                txtTongHop.Text = txtTongHop.Text + "-Du lịch\r\t";
            }

            txtTongHop.Text = txtTongHop.Text + "\r\tMàu bạn thích:\r\n";
            if(rdoDo.Checked == true)
            {
                txtTongHop.Text = txtTongHop.Text + "Đỏ\r\n";
            }
            else if (rdoTrang.Checked == true)
            {
                txtTongHop.Text = txtTongHop.Text + "Trắng\r\n";
            }
            else if (rdoXanh.Checked == true)
            {
                txtTongHop.Text = txtTongHop.Text + "Xanh\r\n";
            }
        }
    }
}
