using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form home;

        private void moHome(Form childForm)
        {
            if (home != null)
            {
                home.Close();
            }
            home = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            body.Controls.Add(childForm);
            body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moHome(new TrangChu());
            label1.Text = btTrangChu.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moHome(new KiemTra());
            label1.Text = btKiemTra.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moHome(new LichSu());
            label1.Text = btLichSu.Text;
        }

        private void btdangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();

                DangNhap dangnhap = new DangNhap();
                dangnhap.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (home != null)
            {
                home.Close();
            }
        }
    }
}
