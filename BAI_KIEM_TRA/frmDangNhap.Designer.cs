namespace Bai_Kiem_Tra
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxChonLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập để làm bài kiểm tra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn lớp";
            // 
            // cbxChonLop
            // 
            this.cbxChonLop.FormattingEnabled = true;
            this.helpProvider1.SetHelpString(this.cbxChonLop, "21CT114");
            this.cbxChonLop.Items.AddRange(new object[] {
            "21CT113",
            "21CT114"});
            this.cbxChonLop.Location = new System.Drawing.Point(180, 52);
            this.cbxChonLop.Name = "cbxChonLop";
            this.helpProvider1.SetShowHelp(this.cbxChonLop, true);
            this.cbxChonLop.Size = new System.Drawing.Size(284, 24);
            this.cbxChonLop.TabIndex = 2;
            this.cbxChonLop.Validating += new System.ComponentModel.CancelEventHandler(this.cbxChonLop_Validating);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Đăng Nhập";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật Khẩu";
            // 
            // txtTenDangNhap
            // 
            this.helpProvider1.SetHelpString(this.txtTenDangNhap, "Vu Minh Phuong");
            this.txtTenDangNhap.Location = new System.Drawing.Point(180, 82);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.helpProvider1.SetShowHelp(this.txtTenDangNhap, true);
            this.txtTenDangNhap.Size = new System.Drawing.Size(284, 22);
            this.txtTenDangNhap.TabIndex = 6;
            this.txtTenDangNhap.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenDangNhap_Validating);
            // 
            // txtMatKhau
            // 
            this.helpProvider1.SetHelpString(this.txtMatKhau, "121001175");
            this.txtMatKhau.Location = new System.Drawing.Point(180, 110);
            this.txtMatKhau.Name = "txtMatKhau";
            this.helpProvider1.SetShowHelp(this.txtMatKhau, true);
            this.txtMatKhau.Size = new System.Drawing.Size(284, 22);
            this.txtMatKhau.TabIndex = 7;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhau_Validating);
            // 
            // btnDangNhap
            // 
            this.helpProvider1.SetHelpString(this.btnDangNhap, "Nhấn để truy cập chương trình");
            this.btnDangNhap.Location = new System.Drawing.Point(276, 138);
            this.btnDangNhap.Name = "btnDangNhap";
            this.helpProvider1.SetShowHelp(this.btnDangNhap, true);
            this.btnDangNhap.Size = new System.Drawing.Size(91, 30);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.helpProvider1.SetHelpString(this.btnThoat, "Nhấn để thoát chương trình");
            this.btnThoat.Location = new System.Drawing.Point(373, 138);
            this.btnThoat.Name = "btnThoat";
            this.helpProvider1.SetShowHelp(this.btnThoat, true);
            this.btnThoat.Size = new System.Drawing.Size(91, 30);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 180);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxChonLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ktrDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxChonLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

