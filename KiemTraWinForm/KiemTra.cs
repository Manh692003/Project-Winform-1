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
    public partial class KiemTra : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        String str = @"Data Source=DESKTOP-BNUOIPK;Initial Catalog=KIEMTRACUOIKY;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public KiemTra()
        {
            InitializeComponent();
        }

        private Form kiemtra;

        private void moKiemTra(Form childForm)
        {
            if (kiemtra != null)
            {
                kiemtra.Close();
            }
            kiemtra = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            body.Controls.Add(childForm);
            body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from TaoDe where day(GETDATE()) - day(KetThuc) <= 0 and day(BatDau) - day(getdate()) <= 0 and MonThi = N'Toán'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgv.DataSource = dt;

            if (dgv.RowCount - 1 <= 0)
            {
                MessageBox.Show("Bài thi hiện chưa có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                Random form = new Random();
                int value = form.Next(1, 4);
                switch (value)
                {
                    case 1:
                        Toan toan = new Toan();
                        toan.ShowDialog();
                        break;
                    case 2:
                        Toan1 toan1 = new Toan1();
                        toan1.ShowDialog();
                        break;
                    case 3:
                        Toan2 toan2 = new Toan2();
                        toan2.ShowDialog();
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from TaoDe where day(GETDATE()) - day(KetThuc) <= 0 and day(BatDau) - day(getdate()) <= 0 and MonThi = N'Anh'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgv.DataSource = dt;
            con.Close();

            if (dgv.RowCount - 1 <= 0)
            {
                MessageBox.Show("Bài thi hiện chưa có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Random form = new Random();
                int value = form.Next(1, 4);
                switch (value)
                {
                    case 1:
                        Anh anh = new Anh();
                        anh.ShowDialog();
                        break;
                    case 2:
                        Anh1 anh1 = new Anh1();
                        anh1.ShowDialog();
                        break;
                    case 3:
                        Anh2 anh2 = new Anh2();
                        anh2.ShowDialog();
                        break;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from TaoDe where day(GETDATE()) - day(KetThuc) <= 0 and day(BatDau) - day(getdate()) <= 0 and MonThi = N'C'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgv.DataSource = dt;

            if (dgv.RowCount - 1 <= 0)
            {
                MessageBox.Show("Bài thi hiện chưa có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Random form = new Random();
                int value = form.Next(1, 4);
                switch (value)
                {
                    case 1:
                        C c = new C();
                        c.ShowDialog();
                        break;
                    case 2:
                        C1 c1 = new C1();
                        c1.ShowDialog();
                        break;
                    case 3:
                        C2 c2 = new C2();
                        c2.ShowDialog();
                        break;
                }
            }
        }
    }
}
