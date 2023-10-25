namespace Bai_Kiem_Tra
{
    partial class frmListBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstLuaChon = new System.Windows.Forms.ListBox();
            this.btnChonHet = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnBoHet = new System.Windows.Forms.Button();
            this.btnBo = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký môn thể thao";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(70, 46);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(150, 20);
            this.txtTenMon.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(236, 48);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 19);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(296, 48);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 19);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(9, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(142, 184);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Items.AddRange(new object[] {
            "Bóng đá ",
            "Bóng bàn ",
            "Cầu lông ",
            "Quần vợt"});
            this.lstDanhSach.Location = new System.Drawing.Point(4, 18);
            this.lstDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(132, 160);
            this.lstDanhSach.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLuaChon);
            this.groupBox2.Location = new System.Drawing.Point(211, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(142, 184);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa chọn";
            // 
            // lstLuaChon
            // 
            this.lstLuaChon.FormattingEnabled = true;
            this.lstLuaChon.Items.AddRange(new object[] {
            "Cầu lông"});
            this.lstLuaChon.Location = new System.Drawing.Point(4, 18);
            this.lstLuaChon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstLuaChon.Name = "lstLuaChon";
            this.lstLuaChon.Size = new System.Drawing.Size(134, 160);
            this.lstLuaChon.TabIndex = 0;
            // 
            // btnChonHet
            // 
            this.btnChonHet.Location = new System.Drawing.Point(155, 110);
            this.btnChonHet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChonHet.Name = "btnChonHet";
            this.btnChonHet.Size = new System.Drawing.Size(51, 37);
            this.btnChonHet.TabIndex = 7;
            this.btnChonHet.Text = ">>";
            this.btnChonHet.UseVisualStyleBackColor = true;
            this.btnChonHet.Click += new System.EventHandler(this.btnChonHet_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(155, 151);
            this.btnChon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(51, 37);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = ">";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnBoHet
            // 
            this.btnBoHet.Location = new System.Drawing.Point(155, 193);
            this.btnBoHet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBoHet.Name = "btnBoHet";
            this.btnBoHet.Size = new System.Drawing.Size(51, 37);
            this.btnBoHet.TabIndex = 9;
            this.btnBoHet.Text = "<<";
            this.btnBoHet.UseVisualStyleBackColor = true;
            this.btnBoHet.Click += new System.EventHandler(this.btnBoHet_Click);
            // 
            // btnBo
            // 
            this.btnBo.Location = new System.Drawing.Point(155, 232);
            this.btnBo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBo.Name = "btnBo";
            this.btnBo.Size = new System.Drawing.Size(51, 37);
            this.btnBo.TabIndex = 10;
            this.btnBo.Text = "<";
            this.btnBo.UseVisualStyleBackColor = true;
            this.btnBo.Click += new System.EventHandler(this.btnBo_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(22, 302);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(67, 37);
            this.btnXemChiTiet.TabIndex = 11;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(22, 344);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 37);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Location = new System.Drawing.Point(110, 290);
            this.txtChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChiTiet.Multiline = true;
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(240, 110);
            this.txtChiTiet.TabIndex = 13;
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 409);
            this.Controls.Add(this.txtChiTiet);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnBo);
            this.Controls.Add(this.btnBoHet);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnChonHet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstLuaChon;
        private System.Windows.Forms.Button btnChonHet;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnBoHet;
        private System.Windows.Forms.Button btnBo;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtChiTiet;
    }
}