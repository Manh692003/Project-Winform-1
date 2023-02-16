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
using static System.Net.Mime.MediaTypeNames;

namespace KiemTraWinForm
{
    public partial class TaoDe : Form
    {
        public TaoDe()
        {
            InitializeComponent();
        }

        public static string TenDangNhap = string.Empty;

        SqlConnection con;
        SqlCommand cmd;
        String str = @"Data Source=DESKTOP-BNUOIPK;Initial Catalog=KIEMTRACUOIKY;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into TaoDe values( N'" + kythi.Text + "', N'" + mon.Text + "', '" + batdau.Text + "', '" + kethuc.Text + "', '" + thoigian.Text + "')";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);

            MessageBox.Show("Tạo kỳ thi thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
