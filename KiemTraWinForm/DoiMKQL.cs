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
    public partial class DoiMKQL : Form
    {
        public DoiMKQL()
        {
            InitializeComponent();
        }

        ModifyQL modify = new ModifyQL();

        private void button1_Click(object sender, EventArgs e)
        {
            string tendangnhap = sdt.Text;
            string matkhau = mk.Text;
            string mknew = mkmoi.Text;

            string query = "select * from TaiKhoanQL where TenDangNhap = '" + tendangnhap + "' and MatKhau = '" + matkhau + "'";

            if (modify.TaiKhoans(query).Count != 0)
            {
                string query1 = "update TaiKhoanQL set MatKhau = '" + mknew + "' where TenDangNhap = '" + tendangnhap + "' and MatKhau = '" + matkhau + "'";
                modify.Connand(query1);

                MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc số điện thoại chưa được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
