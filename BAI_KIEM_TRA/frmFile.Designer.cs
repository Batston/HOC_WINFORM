namespace Bai_Kiem_Tra
{
    partial class frmFile
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
            this.picboxHienThi = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.myFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChonNhieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxHienThi
            // 
            this.picboxHienThi.Location = new System.Drawing.Point(12, 92);
            this.picboxHienThi.Name = "picboxHienThi";
            this.picboxHienThi.Size = new System.Drawing.Size(251, 265);
            this.picboxHienThi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxHienThi.TabIndex = 0;
            this.picboxHienThi.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(303, 30);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn 1 File";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Location = new System.Drawing.Point(269, 92);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(361, 265);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // btnChonNhieu
            // 
            this.btnChonNhieu.Location = new System.Drawing.Point(384, 30);
            this.btnChonNhieu.Name = "btnChonNhieu";
            this.btnChonNhieu.Size = new System.Drawing.Size(75, 23);
            this.btnChonNhieu.TabIndex = 4;
            this.btnChonNhieu.Text = "Chọn 2 File";
            this.btnChonNhieu.UseVisualStyleBackColor = true;
            this.btnChonNhieu.Click += new System.EventHandler(this.btnChonNhieu_Click);
            // 
            // frmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 369);
            this.Controls.Add(this.btnChonNhieu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picboxHienThi);
            this.Name = "frmFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFile";
            this.Load += new System.EventHandler(this.frmFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxHienThi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FolderBrowserDialog myFolderBrowser;
        private System.Windows.Forms.Button btnChonNhieu;
    }
}