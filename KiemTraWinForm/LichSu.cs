using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace KiemTraWinForm
{
    public partial class LichSu : Form
    {
        public static string TenDangNhap = string.Empty;

        SqlConnection con;
        SqlCommand cmd;
        String str = @"Data Source=DESKTOP-BNUOIPK;Initial Catalog=KIEMTRACUOIKY;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public LichSu()
        {
            InitializeComponent();
            tentk.ReadOnly = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TenDangNhap))
            {
                this.tentk.Text = TenDangNhap;
            }

            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select TenDangNhap as MaSinhVien, MonThi as Mon, Diem as Diem from KetQua where TenDangNhap = '" + tentk.Text + "'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        private void LichSu_Load(object sender, EventArgs e)
        {
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
