namespace Bai_Kiem_Tra
{
    partial class frmMayTinhCoBan
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
            this.txtSoNhat = new System.Windows.Forms.TextBox();
            this.txtSoHai = new System.Windows.Forms.TextBox();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(61, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai:";
            // 
            // txtSoNhat
            // 
            this.txtSoNhat.Location = new System.Drawing.Point(186, 38);
            this.txtSoNhat.Name = "txtSoNhat";
            this.txtSoNhat.Size = new System.Drawing.Size(100, 22);
            this.txtSoNhat.TabIndex = 2;
            this.txtSoNhat.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoNhat_Validating);
            // 
            // txtSoHai
            // 
            this.txtSoHai.Location = new System.Drawing.Point(186, 77);
            this.txtSoHai.Name = "txtSoHai";
            this.txtSoHai.Size = new System.Drawing.Size(100, 22);
            this.txtSoHai.TabIndex = 3;
            this.txtSoHai.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoHai_Validating);
            // 
            // btnNhan
            // 
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhan.Location = new System.Drawing.Point(13, 190);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(54, 51);
            this.btnNhan.TabIndex = 4;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCong.Location = new System.Drawing.Point(13, 133);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(54, 51);
            this.btnCong.TabIndex = 5;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnChia
            // 
            this.btnChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChia.Location = new System.Drawing.Point(73, 190);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(54, 51);
            this.btnChia.TabIndex = 6;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnTru
            // 
            this.btnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTru.Location = new System.Drawing.Point(73, 133);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(54, 51);
            this.btnTru.TabIndex = 7;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(250, 180);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(100, 22);
            this.txtKetQua.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(158, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmMayTinhCoBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.txtSoHai);
            this.Controls.Add(this.txtSoNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMayTinhCoBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMayTinhCoBan";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoNhat;
        private System.Windows.Forms.TextBox txtSoHai;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}