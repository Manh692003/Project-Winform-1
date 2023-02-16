using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraWinForm
{
    public partial class DangNhapQL : Form
    {
        public DangNhapQL()
        {
            InitializeComponent();
        }

        private void hienmk_CheckedChanged(object sender, EventArgs e)
        {
            if (hienmk.Checked == true)
            {
                mk.UseSystemPasswordChar = false;
            }
            else
            {
                mk.UseSystemPasswordChar = true;
            }
        }

        ModifyQL modifyQL = new ModifyQL();

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            string tendn = tdn.Text;
            string matlhau = mk.Text;

            if (tendn.Trim() == null) MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (matlhau.Trim() == null) MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                string query = "select * from TaiKhoanQL where TenDangNhap = '" + tendn + "' and MatKhau = '" + matlhau + "'";
                if (modifyQL.TaiKhoans(query).Count != 0)
                {
                    TrangChuQL.TenDangNhap = tdn.Text;

                    this.Hide();
                    TrangChuQL trangChuQL = new TrangChuQL();
                    trangChuQL.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đang nhập hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.Hide();

             ChonPTDN chon = new ChonPTDN();
             chon.ShowDialog();
        }
    }
}
