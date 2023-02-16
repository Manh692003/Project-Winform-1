using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace KiemTraWinForm
{
    public partial class TrangChu : Form
    {
        public static string TenDangNhap = string.Empty;

        public TrangChu()
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

        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TenDangNhap))
            {
                this.tentk.Text = TenDangNhap;
            }

            string tk = tentk.Text;

            string query = "select * from TaiKhoan where MaSV = '" + tk + "'";

            sdt.Text = modify.TaiKhoans(query)[0].Lop;

            Toan.Lop = sdt.Text;
            Toan1.Lop = sdt.Text;
            Toan2.Lop = sdt.Text;
            Anh.Lop = sdt.Text;
            Anh1.Lop = sdt.Text;
            Anh2.Lop = sdt.Text;
            C.Lop = sdt.Text;
            C1.Lop = sdt.Text;
            C2.Lop = sdt.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moHome(new DoiMK());
            label4.Text = button3.Text;
        }

        Modify modify = new Modify();

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void dientichluy_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tentk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}