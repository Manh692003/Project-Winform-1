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
    public partial class QLTaiKhoan : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        String str = @"Data Source=DESKTOP-BNUOIPK;Initial Catalog=KIEMTRACUOIKY;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from TaiKhoan";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        public QLTaiKhoan()
        {
            InitializeComponent();
        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.LopHoc' table. You can move, or remove it, as needed.
            this.lopHocTableAdapter1.Fill(this.dataSet.LopHoc);

            con = new SqlConnection(str);
            con.Open();
            LoadData();
            masv.ReadOnly = true;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            hoten.Text = dgv.Rows[i].Cells[0].Value.ToString();
            lop.Text = dgv.Rows[i].Cells[1].Value.ToString();
            masv.Text = dgv.Rows[i].Cells[2].Value.ToString();
            matkhau.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "update TaiKhoan set HoTen = N'" + hoten.Text + "', Lop = '" + lop.Text + "', MatKhau = '" + matkhau.Text + "' where MaSV = '" + masv.Text + "'";
            cmd.ExecuteNonQuery();
            LoadData();

            MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from TaiKhoan where masv = '" + masv.Text + "'";
            cmd.ExecuteNonQuery();
            LoadData();

            MessageBox.Show("Đã xóa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from TaiKhoan where Lop = '" + dslop.Text + "'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
    }
}
