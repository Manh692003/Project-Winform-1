namespace KiemTraWinForm
{
    partial class QuyenMatKhau
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ketqua = new System.Windows.Forms.Label();
            this.btlaylaimk = new System.Windows.Forms.Button();
            this.kq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KiemTraWinForm.Properties.Resources.Dang_nhap;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(85, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUÊN MẬT KHẨU";
            // 
            // sdt
            // 
            this.sdt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdt.Location = new System.Drawing.Point(133, 420);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(289, 29);
            this.sdt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã sinh viên";
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua.Location = new System.Drawing.Point(59, 465);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(68, 21);
            this.ketqua.TabIndex = 11;
            this.ketqua.Text = "Kết quả";
            // 
            // btlaylaimk
            // 
            this.btlaylaimk.AutoSize = true;
            this.btlaylaimk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btlaylaimk.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlaylaimk.ForeColor = System.Drawing.Color.Blue;
            this.btlaylaimk.Location = new System.Drawing.Point(120, 521);
            this.btlaylaimk.Name = "btlaylaimk";
            this.btlaylaimk.Size = new System.Drawing.Size(179, 58);
            this.btlaylaimk.TabIndex = 12;
            this.btlaylaimk.Text = "Lấy lại MK";
            this.btlaylaimk.UseVisualStyleBackColor = false;
            this.btlaylaimk.Click += new System.EventHandler(this.btlaylaimk_Click);
            // 
            // kq
            // 
            this.kq.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kq.Location = new System.Drawing.Point(133, 461);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(289, 29);
            this.kq.TabIndex = 13;
            // 
            // QuyenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 611);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.btlaylaimk);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "QuyenMatKhau";
            this.Text = "QuyenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.Button btlaylaimk;
        private System.Windows.Forms.TextBox kq;
    }
}