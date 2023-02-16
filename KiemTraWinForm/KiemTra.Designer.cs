namespace KiemTraWinForm
{
    partial class KiemTra
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
            this.lb = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btDe2 = new System.Windows.Forms.Button();
            this.btDe1 = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lb.SuspendLayout();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.Controls.Add(this.button1);
            this.lb.Controls.Add(this.btDe2);
            this.lb.Controls.Add(this.btDe1);
            this.lb.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(0, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(135, 433);
            this.lb.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Môn C";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btDe2
            // 
            this.btDe2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btDe2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDe2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDe2.ForeColor = System.Drawing.Color.White;
            this.btDe2.Location = new System.Drawing.Point(0, 84);
            this.btDe2.Name = "btDe2";
            this.btDe2.Size = new System.Drawing.Size(135, 84);
            this.btDe2.TabIndex = 1;
            this.btDe2.Text = "Môn Anh";
            this.btDe2.UseVisualStyleBackColor = false;
            this.btDe2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btDe1
            // 
            this.btDe1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btDe1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDe1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDe1.ForeColor = System.Drawing.Color.White;
            this.btDe1.Location = new System.Drawing.Point(0, 0);
            this.btDe1.Name = "btDe1";
            this.btDe1.Size = new System.Drawing.Size(135, 84);
            this.btDe1.TabIndex = 0;
            this.btDe1.Text = "Môn Toán";
            this.btDe1.UseVisualStyleBackColor = false;
            this.btDe1.Click += new System.EventHandler(this.button1_Click);
            // 
            // body
            // 
            this.body.Controls.Add(this.pictureBox1);
            this.body.Controls.Add(this.dgv);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(135, 0);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(849, 433);
            this.body.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::KiemTraWinForm.Properties.Resources.ubk;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(849, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(254, 128);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(180, 122);
            this.dgv.TabIndex = 2;
            // 
            // KiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 433);
            this.Controls.Add(this.body);
            this.Controls.Add(this.lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KiemTra";
            this.Text = "KiemTra";
            this.lb.ResumeLayout(false);
            this.body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lb;
        private System.Windows.Forms.Button btDe2;
        private System.Windows.Forms.Button btDe1;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv;
    }
}