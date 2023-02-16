using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace KiemTraWinForm
{
    public partial class TrangChuQL : Form
    {
        public static string TenDangNhap = string.Empty;

        public TrangChuQL()
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

        private void button3_Click(object sender, EventArgs e)
        {
            moHome(new CaiDat());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moHome(new LichSuQL());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moHome(new TaoDe());
        }

        private void btdangxuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();

                DangNhapQL dangnhapQL = new DangNhapQL();
                dangnhapQL.ShowDialog();
            }
        }

        private void tendn_Click(object sender, EventArgs e)
        {
            
        }

        private void TrangChuQL_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TenDangNhap))
            {
                this.tendn.Text = TenDangNhap;
            }

            string tk = tendn.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (home != null)
            {
                home.Close();
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            moHome(new TaoLop());
        }
    }
}
