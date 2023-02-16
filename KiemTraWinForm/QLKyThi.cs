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
    public partial class QLKyThi : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        String str = @"Data Source=DESKTOP-BNUOIPK;Initial Catalog=KIEMTRACUOIKY;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        void LoadData()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from TaoDe";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        public QLKyThi()
        {
            InitializeComponent();
        }

        private void QLKyThi_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            LoadData();
            monthi.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "update TaoDe set KyThi = N'" + kythi.Text + "', BatDau = '" + batdau.Text + "', KetThuc = '" + ketthuc.Text + "' where MonThi = '" + monthi.Text + "'";
            cmd.ExecuteNonQuery();
            LoadData();

            MessageBox.Show("Sửa thông tin kỳ thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from TaoDe where MonThi = '" + monthi.Text + "'";
            cmd.ExecuteNonQuery();
            LoadData();

            MessageBox.Show("Đã xóa kỳ thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            kythi.Text = dgv.Rows[i].Cells[0].Value.ToString();
            monthi.Text = dgv.Rows[i].Cells[1].Value.ToString();
            batdau.Text = dgv.Rows[i].Cells[2].Value.ToString();
            ketthuc.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }
    }
}
