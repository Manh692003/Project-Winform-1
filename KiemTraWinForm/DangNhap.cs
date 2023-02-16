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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void quyenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuyenMatKhau quyenmatkhau = new QuyenMatKhau();
            quyenmatkhau.ShowDialog();
        }

        Modify modify = new Modify();

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            string tendn = tdn.Text;
            string matlhau = mk.Text;

            if (tendn.Trim() == null) MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (matlhau.Trim() == null) MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                string query = "select * from TaiKhoan where MaSV = '" + tendn + "' and MatKhau = '" + matlhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    TrangChu.TenDangNhap = tdn.Text;
                    LichSu.TenDangNhap = tdn.Text;
                    Toan.TenDangNhap = tdn.Text;
                    Toan1.TenDangNhap= tdn.Text;
                    Toan2.TenDangNhap = tdn.Text;
                    Anh.TenDangNhap = tdn.Text;
                    Anh1.TenDangNhap = tdn.Text;
                    Anh2.TenDangNhap = tdn.Text;
                    C.TenDangNhap = tdn.Text;
                    C1.TenDangNhap = tdn.Text;
                    C2.TenDangNhap = tdn.Text;


                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                } else {
                    MessageBox.Show("Tên đang nhập hoặc một khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hienmk.Checked == true) {
                mk.UseSystemPasswordChar = false;
            } 
            else
            {
                mk.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ChonPTDN chon = new ChonPTDN();
            chon.ShowDialog();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
