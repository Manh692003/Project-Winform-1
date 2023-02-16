namespace KiemTraWinForm
{
    partial class ThemHS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.masv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mk = new System.Windows.Forms.TextBox();
            this.luulop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lop = new System.Windows.Forms.ComboBox();
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new KiemTraWinForm.DataSet();
            this.lopHocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocTableAdapter1 = new KiemTraWinForm.DataSetTableAdapters.LopHocTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập sinh viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 41);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ tên sinh viên";
            // 
            // hoten
            // 
            this.hoten.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten.Location = new System.Drawing.Point(9, 102);
            this.hoten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(391, 29);
            this.hoten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã sinh viên";
            // 
            // masv
            // 
            this.masv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masv.Location = new System.Drawing.Point(9, 249);
            this.masv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masv.Name = "masv";
            this.masv.Size = new System.Drawing.Size(391, 29);
            this.masv.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu";
            // 
            // mk
            // 
            this.mk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mk.Location = new System.Drawing.Point(9, 324);
            this.mk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(391, 29);
            this.mk.TabIndex = 7;
            // 
            // luulop
            // 
            this.luulop.AutoSize = true;
            this.luulop.BackColor = System.Drawing.Color.RoyalBlue;
            this.luulop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luulop.ForeColor = System.Drawing.Color.White;
            this.luulop.Location = new System.Drawing.Point(242, 389);
            this.luulop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.luulop.Name = "luulop";
            this.luulop.Size = new System.Drawing.Size(87, 32);
            this.luulop.TabIndex = 9;
            this.luulop.Text = "Lưu lại";
            this.luulop.UseVisualStyleBackColor = false;
            this.luulop.Click += new System.EventHandler(this.luulop_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(70, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lớp";
            // 
            // lop
            // 
            this.lop.DataSource = this.lopHocBindingSource1;
            this.lop.DisplayMember = "TenLop";
            this.lop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lop.FormattingEnabled = true;
            this.lop.Location = new System.Drawing.Point(9, 175);
            this.lop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(391, 28);
            this.lop.TabIndex = 13;
            // 
            // lopHocBindingSource
            // 
            this.lopHocBindingSource.DataMember = "LopHoc";
            // 
            // dataSet1
            // 
            // 
            // lopHocTableAdapter
            // 
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopHocBindingSource1
            // 
            this.lopHocBindingSource1.DataMember = "LopHoc";
            this.lopHocBindingSource1.DataSource = this.dataSet;
            // 
            // lopHocTableAdapter1
            // 
            this.lopHocTableAdapter1.ClearBeforeFill = true;
            // 
            // ThemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 453);
            this.Controls.Add(this.lop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.luulop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.masv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThemHS";
            this.Text = "ThemHS";
            this.Load += new System.EventHandler(this.ThemHS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox masv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mk;
        private System.Windows.Forms.Button luulop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lop;
        private System.Windows.Forms.BindingSource lopHocBindingSource;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource lopHocBindingSource1;
        private DataSetTableAdapters.LopHocTableAdapter lopHocTableAdapter1;
    }
}