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
    public partial class C2 : Form
    {
        public static string TenDangNhap = string.Empty;
        public static string Lop = string.Empty;

        SqlConnection con;
        SqlCommand cmd;
        String str = @"Data Source=DESKTOP-BNUOIPK;Initial Catalog=KIEMTRACUOIKY;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public C2()
        {
            InitializeComponent();
            tinhgio.Start();
        }

        private void C2_Load(object sender, EventArgs e)
        {
            tenlop.Text = "72DCTT21";

            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select KyThi from TaoDe where MonThi = N'C'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgv.DataSource = dt;
            kt.DataBindings.Add("text", dgv.DataSource, "KyThi");

            if (!string.IsNullOrEmpty(TenDangNhap))
            {
                this.msv.Text = TenDangNhap;
            }

            if (!string.IsNullOrEmpty(Lop))
            {
                this.tenlop.Text = Lop;
            }

            string tk = msv.Text;
            string tl = tenlop.Text;
        }

        bool KTDapAn(Label lb, Panel pal)
        {
            RadioButton ckb = null;
            foreach (RadioButton item in pal.Controls)
            {
                if (item != null)
                {
                    if (item.Checked)
                    {
                        ckb = item;

                        break;
                    }
                }
            }
            if (ckb == da1 || ckb == da2 || ckb == da3 || ckb == da4 || ckb == da5 || ckb == da6 || ckb == da7 || ckb == da8 || ckb == da9 || ckb == da10) return true;

            else return false;
        }

        Modify modify = new Modify();

        private void nopbai_Click(object sender, EventArgs e)
        {
            if (tinhgio.Enabled)
            {
                tinhgio.Stop();
            }

            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from KetQua where MonThi = N'C' and TenDangNhap = '" + msv.Text + "'";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            lanthi.DataSource = dt;

            this.Hide();

            if (lanthi.RowCount - 1 == 0)
            {
                if (tinhgio.Enabled)
                {
                    tinhgio.Stop();
                }

                int diem = 0;
                if (KTDapAn(cau1, dan1) == true)
                {
                    diem += 1;
                    check1.Text = "Đúng";
                }

                if (KTDapAn(cau2, dan2) == true)
                {
                    diem += 1;
                    check2.Text = "Đúng";
                }

                if (KTDapAn(cau3, dan3) == true)
                {
                    diem += 1;
                    check3.Text = "Đúng";
                }

                if (KTDapAn(cau4, dan4) == true)
                {
                    diem += 1;
                    check4.Text = "Đúng";
                }

                if (KTDapAn(cau5, dan5) == true)
                {
                    diem += 1;
                    check5.Text = "Đúng";
                }

                if (KTDapAn(cau6, dan6) == true)
                {
                    diem += 1;
                    check6.Text = "Đúng";
                }

                if (KTDapAn(cau7, dan7) == true)
                {
                    diem += 1;
                    check7.Text = "Đúng";
                }

                if (KTDapAn(cau8, dan8) == true)
                {
                    diem += 1;
                    check8.Text = "Đúng";
                }

                if (KTDapAn(cau9, dan9) == true)
                {
                    diem += 1;
                    check9.Text = "Đúng";
                }

                if (KTDapAn(cau10, dan10) == true)
                {
                    diem += 1;
                    check10.Text = "Đúng";
                }

                KQC2.DiemThi = diem.ToString();
                KQC2.ck1 = check1.Text;
                KQC2.ck2 = check2.Text;
                KQC2.ck3 = check3.Text;
                KQC2.ck4 = check4.Text;
                KQC2.ck5 = check5.Text;
                KQC2.ck6 = check6.Text;
                KQC2.ck7 = check7.Text;
                KQC2.ck8 = check8.Text;
                KQC2.ck9 = check9.Text;
                KQC2.ck10 = check10.Text;

                string query = "insert into KetQua values ('" + tenlop.Text + "', '" + msv.Text + "', '" + mon.Text + "', " + diem + ")";
                modify.Connand(query);

                KQC2 kQ = new KQC2();
                kQ.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn đã làm bài thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        int i = 30;

        private void tinhgio_Tick(object sender, EventArgs e)
        {
            i--;
            thoigian.Text = i.ToString();
            if (i == 0)
            {
                nopbai_Click(sender, e);
            }
        }

        private void cau7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thoigian_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mon_Click(object sender, EventArgs e)
        {

        }

        private void msv_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kt_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void check1_Click(object sender, EventArgs e)
        {

        }

        private void check2_Click(object sender, EventArgs e)
        {

        }

        private void check3_Click(object sender, EventArgs e)
        {

        }

        private void check4_Click(object sender, EventArgs e)
        {

        }

        private void check5_Click(object sender, EventArgs e)
        {

        }

        private void lanthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tenlop_TextChanged(object sender, EventArgs e)
        {

        }

        private void dan8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void c10_Enter(object sender, EventArgs e)
        {

        }

        private void dan10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void da10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cau10_Click(object sender, EventArgs e)
        {

        }

        private void check10_Click(object sender, EventArgs e)
        {

        }

        private void c9_Enter(object sender, EventArgs e)
        {

        }

        private void dan9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void da9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cau9_Click(object sender, EventArgs e)
        {

        }

        private void check9_Click(object sender, EventArgs e)
        {

        }

        private void c8_Enter(object sender, EventArgs e)
        {

        }

        private void da8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cau8_Click(object sender, EventArgs e)
        {

        }

        private void check8_Click(object sender, EventArgs e)
        {

        }

        private void c7_Enter(object sender, EventArgs e)
        {

        }

        private void dan7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void da7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void check7_Click(object sender, EventArgs e)
        {

        }

        private void c6_Enter(object sender, EventArgs e)
        {

        }

        private void dan6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void da6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void check6_Click(object sender, EventArgs e)
        {

        }

        private void cau6_Click(object sender, EventArgs e)
        {

        }

        private void c5_Enter(object sender, EventArgs e)
        {

        }

        private void dan5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void da5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cau5_Click(object sender, EventArgs e)
        {

        }

        private void c4_Enter(object sender, EventArgs e)
        {

        }

        private void dan4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void da4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cau4_Click(object sender, EventArgs e)
        {

        }

        private void c3_Enter(object sender, EventArgs e)
        {

        }

        private void dan3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void da3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cau3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dan2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void da2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cau2_Click(object sender, EventArgs e)
        {

        }

        private void c1_Enter(object sender, EventArgs e)
        {

        }

        private void dan1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void da1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cau1_Click(object sender, EventArgs e)
        {

        }
    }
}
