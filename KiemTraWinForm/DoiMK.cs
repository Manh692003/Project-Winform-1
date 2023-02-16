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
    public partial class DoiMK : Form
    {
        public DoiMK()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sodienthoai = sdt.Text;
            string matkhau = mk.Text;
            string mknew = mkmoi.Text;

            string query = "select * from TaiKhoan where MaSV = '" + sodienthoai + "' and MatKhau = '" + matkhau + "'";

            if (modify.TaiKhoans(query).Count != 0)
            {
                string query1 = "update TaiKhoan set MatKhau = '" + mknew + "' where MaSV = '" + sodienthoai + "' and MatKhau = '" + matkhau + "'";
                modify.Connand(query1);

                MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc số điện thoại chưa được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
