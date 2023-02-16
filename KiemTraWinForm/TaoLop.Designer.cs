namespace KiemTraWinForm
{
    partial class TaoLop
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
            this.button1 = new System.Windows.Forms.Button();
            this.dslop = new System.Windows.Forms.DataGridView();
            this.themhs = new System.Windows.Forms.Button();
            this.luulop = new System.Windows.Forms.Button();
            this.trangthai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tenlop = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dslop)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dslop);
            this.panel1.Controls.Add(this.themhs);
            this.panel1.Controls.Add(this.luulop);
            this.panel1.Controls.Add(this.trangthai);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mota);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tenlop);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 457);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(669, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Danh sách lớp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dslop
            // 
            this.dslop.AllowUserToAddRows = false;
            this.dslop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dslop.Location = new System.Drawing.Point(16, 188);
            this.dslop.Margin = new System.Windows.Forms.Padding(2);
            this.dslop.Name = "dslop";
            this.dslop.RowHeadersWidth = 51;
            this.dslop.RowTemplate.Height = 24;
            this.dslop.Size = new System.Drawing.Size(796, 225);
            this.dslop.TabIndex = 10;
            // 
            // themhs
            // 
            this.themhs.AutoSize = true;
            this.themhs.BackColor = System.Drawing.Color.RoyalBlue;
            this.themhs.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themhs.ForeColor = System.Drawing.Color.White;
            this.themhs.Location = new System.Drawing.Point(163, 418);
            this.themhs.Margin = new System.Windows.Forms.Padding(2);
            this.themhs.Name = "themhs";
            this.themhs.Size = new System.Drawing.Size(143, 32);
            this.themhs.TabIndex = 9;
            this.themhs.Text = "Thêm sinh viên";
            this.themhs.UseVisualStyleBackColor = false;
            this.themhs.Click += new System.EventHandler(this.themhs_Click);
            // 
            // luulop
            // 
            this.luulop.AutoSize = true;
            this.luulop.BackColor = System.Drawing.Color.RoyalBlue;
            this.luulop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luulop.ForeColor = System.Drawing.Color.White;
            this.luulop.Location = new System.Drawing.Point(16, 418);
            this.luulop.Margin = new System.Windows.Forms.Padding(2);
            this.luulop.Name = "luulop";
            this.luulop.Size = new System.Drawing.Size(143, 32);
            this.luulop.TabIndex = 8;
            this.luulop.Text = "Lưu lớp học";
            this.luulop.UseVisualStyleBackColor = false;
            this.luulop.Click += new System.EventHandler(this.luulop_Click);
            // 
            // trangthai
            // 
            this.trangthai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangthai.FormattingEnabled = true;
            this.trangthai.Items.AddRange(new object[] {
            "Mở",
            "Đóng"});
            this.trangthai.Location = new System.Drawing.Point(278, 143);
            this.trangthai.Margin = new System.Windows.Forms.Padding(2);
            this.trangthai.Name = "trangthai";
            this.trangthai.Size = new System.Drawing.Size(422, 28);
            this.trangthai.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trang thái lớp học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mô tả";
            // 
            // mota
            // 
            this.mota.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mota.Location = new System.Drawing.Point(278, 102);
            this.mota.Margin = new System.Windows.Forms.Padding(2);
            this.mota.Name = "mota";
            this.mota.Size = new System.Drawing.Size(422, 29);
            this.mota.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên lớp học";
            // 
            // tenlop
            // 
            this.tenlop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenlop.Location = new System.Drawing.Point(278, 63);
            this.tenlop.Margin = new System.Windows.Forms.Padding(2);
            this.tenlop.Name = "tenlop";
            this.tenlop.Size = new System.Drawing.Size(422, 29);
            this.tenlop.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 41);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập thông tin chung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHẬP LỚP HỌC";
            // 
            // TaoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaoLop";
            this.Text = "TaoLop";
            this.Load += new System.EventHandler(this.TaoLop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dslop)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dslop;
        private System.Windows.Forms.Button themhs;
        private System.Windows.Forms.Button luulop;
        private System.Windows.Forms.ComboBox trangthai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenlop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}