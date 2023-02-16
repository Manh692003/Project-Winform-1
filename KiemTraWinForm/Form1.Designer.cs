namespace KiemTraWinForm
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTrangChu = new System.Windows.Forms.Button();
            this.btKiemTra = new System.Windows.Forms.Button();
            this.btLichSu = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.Panel();
            this.btdangxuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btTrangChu);
            this.panel1.Controls.Add(this.btKiemTra);
            this.panel1.Controls.Add(this.btLichSu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 0;
            // 
            // btTrangChu
            // 
            this.btTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btTrangChu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btTrangChu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrangChu.ForeColor = System.Drawing.Color.Blue;
            this.btTrangChu.Location = new System.Drawing.Point(0, 0);
            this.btTrangChu.Name = "btTrangChu";
            this.btTrangChu.Size = new System.Drawing.Size(322, 100);
            this.btTrangChu.TabIndex = 0;
            this.btTrangChu.Text = "Trang Chủ";
            this.btTrangChu.UseVisualStyleBackColor = false;
            this.btTrangChu.Click += new System.EventHandler(this.button4_Click);
            // 
            // btKiemTra
            // 
            this.btKiemTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btKiemTra.Dock = System.Windows.Forms.DockStyle.Right;
            this.btKiemTra.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKiemTra.ForeColor = System.Drawing.Color.Blue;
            this.btKiemTra.Location = new System.Drawing.Point(322, 0);
            this.btKiemTra.Name = "btKiemTra";
            this.btKiemTra.Size = new System.Drawing.Size(328, 100);
            this.btKiemTra.TabIndex = 1;
            this.btKiemTra.Text = "Kiểm Tra";
            this.btKiemTra.UseVisualStyleBackColor = false;
            this.btKiemTra.Click += new System.EventHandler(this.button3_Click);
            // 
            // btLichSu
            // 
            this.btLichSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btLichSu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btLichSu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLichSu.ForeColor = System.Drawing.Color.Blue;
            this.btLichSu.Location = new System.Drawing.Point(650, 0);
            this.btLichSu.Name = "btLichSu";
            this.btLichSu.Size = new System.Drawing.Size(334, 100);
            this.btLichSu.TabIndex = 3;
            this.btLichSu.Text = "Lịch Sử";
            this.btLichSu.UseVisualStyleBackColor = false;
            this.btLichSu.Click += new System.EventHandler(this.button1_Click);
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.Navy;
            this.body.Controls.Add(this.btdangxuat);
            this.body.Controls.Add(this.pictureBox1);
            this.body.Controls.Add(this.panel2);
            this.body.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.body.Location = new System.Drawing.Point(0, 100);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(984, 461);
            this.body.TabIndex = 2;
            // 
            // btdangxuat
            // 
            this.btdangxuat.AutoSize = true;
            this.btdangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btdangxuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangxuat.ForeColor = System.Drawing.Color.Blue;
            this.btdangxuat.Location = new System.Drawing.Point(855, 420);
            this.btdangxuat.Name = "btdangxuat";
            this.btdangxuat.Size = new System.Drawing.Size(126, 37);
            this.btdangxuat.TabIndex = 8;
            this.btdangxuat.Text = "Đăng Xuất";
            this.btdangxuat.UseVisualStyleBackColor = false;
            this.btdangxuat.Click += new System.EventHandler(this.btdangxuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::KiemTraWinForm.Properties.Resources.adasd;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 28);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KiemTraWinForm.Properties.Resources.dx;
            this.pictureBox2.Location = new System.Drawing.Point(956, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình thi trắc nghiệm trên máy tính";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.body);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btTrangChu;
        private System.Windows.Forms.Button btKiemTra;
        private System.Windows.Forms.Button btLichSu;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdangxuat;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

