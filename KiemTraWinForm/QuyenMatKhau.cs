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
    public partial class QuyenMatKhau : Form
    {
        public QuyenMatKhau()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();

        private void btlaylaimk_Click(object sender, EventArgs e)
        {
            string sodienthoai = sdt.Text;

            if (sodienthoai.Trim() == null)
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "select * from TaiKhoan where MaSV = '" + sodienthoai + "'";

                if (modify.TaiKhoans(query).Count != 0)
                {
                    kq.Text = modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    kq.Text = "Mã sinh viên chưa được đăng ký!";
                }
            }
        }
    }
}
