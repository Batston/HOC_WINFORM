namespace Bai_Kiem_Tra
{
    partial class frmRadioCheckBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHienThi = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxSoThich = new System.Windows.Forms.GroupBox();
            this.cbxDuLich = new System.Windows.Forms.CheckBox();
            this.cbxLapTrinh = new System.Windows.Forms.CheckBox();
            this.cbxXemPhim = new System.Windows.Forms.CheckBox();
            this.cbxGame = new System.Windows.Forms.CheckBox();
            this.cbxNgheNhac = new System.Windows.Forms.CheckBox();
            this.cbxCheckAll = new System.Windows.Forms.CheckBox();
            this.gbxMau = new System.Windows.Forms.GroupBox();
            this.rdoXanh = new System.Windows.Forms.RadioButton();
            this.rdoTrang = new System.Windows.Forms.RadioButton();
            this.rdoDo = new System.Windows.Forms.RadioButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnTongHop = new System.Windows.Forms.Button();
            this.txtTongHop = new System.Windows.Forms.TextBox();
            this.gbxSoThich.SuspendLayout();
            this.gbxMau.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHienThi.ForeColor = System.Drawing.Color.Red;
            this.lblHienThi.Location = new System.Drawing.Point(117, 9);
            this.lblHienThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(128, 24);
            this.lblHienThi.TabIndex = 0;
            this.lblHienThi.Text = "Hiển thị màu";
            // 
            // gbxSoThich
            // 
            this.gbxSoThich.Controls.Add(this.cbxDuLich);
            this.gbxSoThich.Controls.Add(this.cbxLapTrinh);
            this.gbxSoThich.Controls.Add(this.cbxXemPhim);
            this.gbxSoThich.Controls.Add(this.cbxGame);
            this.gbxSoThich.Controls.Add(this.cbxNgheNhac);
            this.gbxSoThich.Controls.Add(this.cbxCheckAll);
            this.gbxSoThich.Location = new System.Drawing.Point(9, 48);
            this.gbxSoThich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSoThich.Name = "gbxSoThich";
            this.gbxSoThich.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSoThich.Size = new System.Drawing.Size(150, 194);
            this.gbxSoThich.TabIndex = 1;
            this.gbxSoThich.TabStop = false;
            this.gbxSoThich.Text = "Sở thích";
            // 
            // cbxDuLich
            // 
            this.cbxDuLich.AutoSize = true;
            this.cbxDuLich.Location = new System.Drawing.Point(32, 137);
            this.cbxDuLich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDuLich.Name = "cbxDuLich";
            this.cbxDuLich.Size = new System.Drawing.Size(63, 17);
            this.cbxDuLich.TabIndex = 5;
            this.cbxDuLich.Text = "Du Lịch";
            this.cbxDuLich.UseVisualStyleBackColor = true;
            // 
            // cbxLapTrinh
            // 
            this.cbxLapTrinh.AutoSize = true;
            this.cbxLapTrinh.Location = new System.Drawing.Point(32, 115);
            this.cbxLapTrinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxLapTrinh.Name = "cbxLapTrinh";
            this.cbxLapTrinh.Size = new System.Drawing.Size(67, 17);
            this.cbxLapTrinh.TabIndex = 4;
            this.cbxLapTrinh.Text = "Lập trình";
            this.cbxLapTrinh.UseVisualStyleBackColor = true;
            // 
            // cbxXemPhim
            // 
            this.cbxXemPhim.AutoSize = true;
            this.cbxXemPhim.Location = new System.Drawing.Point(32, 72);
            this.cbxXemPhim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxXemPhim.Name = "cbxXemPhim";
            this.cbxXemPhim.Size = new System.Drawing.Size(73, 17);
            this.cbxXemPhim.TabIndex = 3;
            this.cbxXemPhim.Text = "Xem Phim";
            this.cbxXemPhim.UseVisualStyleBackColor = true;
            // 
            // cbxGame
            // 
            this.cbxGame.AutoSize = true;
            this.cbxGame.Location = new System.Drawing.Point(32, 93);
            this.cbxGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxGame.Name = "cbxGame";
            this.cbxGame.Size = new System.Drawing.Size(54, 17);
            this.cbxGame.TabIndex = 2;
            this.cbxGame.Text = "Game";
            this.cbxGame.UseVisualStyleBackColor = true;
            // 
            // cbxNgheNhac
            // 
            this.cbxNgheNhac.AutoSize = true;
            this.cbxNgheNhac.Location = new System.Drawing.Point(32, 50);
            this.cbxNgheNhac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxNgheNhac.Name = "cbxNgheNhac";
            this.cbxNgheNhac.Size = new System.Drawing.Size(81, 17);
            this.cbxNgheNhac.TabIndex = 1;
            this.cbxNgheNhac.Text = "Nghe Nhạc";
            this.cbxNgheNhac.UseVisualStyleBackColor = true;
            // 
            // cbxCheckAll
            // 
            this.cbxCheckAll.AutoSize = true;
            this.cbxCheckAll.Location = new System.Drawing.Point(4, 28);
            this.cbxCheckAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCheckAll.Name = "cbxCheckAll";
            this.cbxCheckAll.Size = new System.Drawing.Size(84, 17);
            this.cbxCheckAll.TabIndex = 0;
            this.cbxCheckAll.Text = "CHECK ALL";
            this.cbxCheckAll.UseVisualStyleBackColor = true;
            this.cbxCheckAll.CheckedChanged += new System.EventHandler(this.cbxCheckAll_CheckedChanged);
            // 
            // gbxMau
            // 
            this.gbxMau.Controls.Add(this.rdoXanh);
            this.gbxMau.Controls.Add(this.rdoTrang);
            this.gbxMau.Controls.Add(this.rdoDo);
            this.gbxMau.Location = new System.Drawing.Point(202, 48);
            this.gbxMau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxMau.Name = "gbxMau";
            this.gbxMau.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxMau.Size = new System.Drawing.Size(150, 194);
            this.gbxMau.TabIndex = 2;
            this.gbxMau.TabStop = false;
            this.gbxMau.Text = "Màu bạn thích";
            // 
            // rdoXanh
            // 
            this.rdoXanh.AutoSize = true;
            this.rdoXanh.Location = new System.Drawing.Point(29, 114);
            this.rdoXanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoXanh.Name = "rdoXanh";
            this.rdoXanh.Size = new System.Drawing.Size(50, 17);
            this.rdoXanh.TabIndex = 5;
            this.rdoXanh.TabStop = true;
            this.rdoXanh.Text = "Xanh";
            this.rdoXanh.UseVisualStyleBackColor = true;
            this.rdoXanh.CheckedChanged += new System.EventHandler(this.rdoXanh_CheckedChanged);
            // 
            // rdoTrang
            // 
            this.rdoTrang.AutoSize = true;
            this.rdoTrang.Location = new System.Drawing.Point(29, 76);
            this.rdoTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTrang.Name = "rdoTrang";
            this.rdoTrang.Size = new System.Drawing.Size(53, 17);
            this.rdoTrang.TabIndex = 4;
            this.rdoTrang.TabStop = true;
            this.rdoTrang.Text = "Trắng";
            this.rdoTrang.UseVisualStyleBackColor = true;
            this.rdoTrang.CheckedChanged += new System.EventHandler(this.rdoTrang_CheckedChanged);
            // 
            // rdoDo
            // 
            this.rdoDo.AutoSize = true;
            this.rdoDo.Location = new System.Drawing.Point(29, 42);
            this.rdoDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoDo.Name = "rdoDo";
            this.rdoDo.Size = new System.Drawing.Size(39, 17);
            this.rdoDo.TabIndex = 3;
            this.rdoDo.TabStop = true;
            this.rdoDo.Text = "Đỏ";
            this.rdoDo.UseVisualStyleBackColor = true;
            this.rdoDo.CheckedChanged += new System.EventHandler(this.rdoDo_CheckedChanged);
            // 
            // btnTongHop
            // 
            this.btnTongHop.Location = new System.Drawing.Point(14, 268);
            this.btnTongHop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTongHop.Name = "btnTongHop";
            this.btnTongHop.Size = new System.Drawing.Size(66, 26);
            this.btnTongHop.TabIndex = 3;
            this.btnTongHop.Text = "Tổng hợp";
            this.btnTongHop.UseVisualStyleBackColor = true;
            this.btnTongHop.Click += new System.EventHandler(this.btnTongHop_Click);
            // 
            // txtTongHop
            // 
            this.txtTongHop.Location = new System.Drawing.Point(84, 268);
            this.txtTongHop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongHop.Multiline = true;
            this.txtTongHop.Name = "txtTongHop";
            this.txtTongHop.Size = new System.Drawing.Size(270, 132);
            this.txtTongHop.TabIndex = 4;
            // 
            // frmRadioCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 409);
            this.Controls.Add(this.txtTongHop);
            this.Controls.Add(this.btnTongHop);
            this.Controls.Add(this.gbxMau);
            this.Controls.Add(this.gbxSoThich);
            this.Controls.Add(this.lblHienThi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRadioCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRadioCheckBox";
            this.gbxSoThich.ResumeLayout(false);
            this.gbxSoThich.PerformLayout();
            this.gbxMau.ResumeLayout(false);
            this.gbxMau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxSoThich;
        private System.Windows.Forms.GroupBox gbxMau;
        private System.Windows.Forms.RadioButton rdoXanh;
        private System.Windows.Forms.RadioButton rdoTrang;
        private System.Windows.Forms.RadioButton rdoDo;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.CheckBox cbxDuLich;
        private System.Windows.Forms.CheckBox cbxLapTrinh;
        private System.Windows.Forms.CheckBox cbxXemPhim;
        private System.Windows.Forms.CheckBox cbxGame;
        private System.Windows.Forms.CheckBox cbxNgheNhac;
        private System.Windows.Forms.CheckBox cbxCheckAll;
        private System.Windows.Forms.Button btnTongHop;
        private System.Windows.Forms.TextBox txtTongHop;
    }
}