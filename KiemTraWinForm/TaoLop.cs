using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KiemTraWinForm
{
    public partial class TaoLop : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        String str = @"Data Source=DESKTOP-BNUOIPK;Initial Catalog=KIEMTRACUOIKY;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public TaoLop()
        {
            InitializeComponent();
        }

        private void themhs_Click(object sender, EventArgs e)
        {
            ThemHS them = new ThemHS();
            them.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSLop dS = new DSLop();
            dS.ShowDialog();
        }

        private void luulop_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into LopHoc values ('" + tenlop.Text + "', N'" + mota.Text + "', N'" + trangthai.Text + "')";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);

            MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TaoLop_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from TaiKhoan";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dslop.DataSource = dt;
        }
    }
}
