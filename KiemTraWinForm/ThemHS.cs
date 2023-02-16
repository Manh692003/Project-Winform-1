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
    public partial class ThemHS : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        String str = @"Data Source=DESKTOP-BNUOIPK;Initial Catalog=KIEMTRACUOIKY;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public ThemHS()
        {
            InitializeComponent();
        }

        private void ThemHS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.LopHoc' table. You can move, or remove it, as needed.
            this.lopHocTableAdapter1.Fill(this.dataSet.LopHoc);
        }

        private void luulop_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into TaiKhoan values (N'" + hoten.Text + "', '" + lop.Text + "', '" + masv.Text + "', '" + mk.Text + "')";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);

            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
