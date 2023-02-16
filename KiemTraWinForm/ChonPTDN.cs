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
    public partial class ChonPTDN : Form
    {
        public ChonPTDN()
        {
            InitializeComponent();
        }

        private void quanly_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DangNhapQL dangnhapql = new DangNhapQL();
            dangnhapql.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }
    }
}
