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
    public partial class C1 : Form
    {
        public static string TenDangNhap = string.Empty;
        public static string Lop = string.Empty;

        SqlConnection con;
        SqlCommand cmd;
        String str = @"Data Source=DESKTOP-BNUOIPK;Initial Catalog=KIEMTRACUOIKY;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public C1()
        {
            InitializeComponent();
            tinhgio.Start();
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

        private void C1_Load(object sender, EventArgs e)
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

                KQC1.DiemThi = diem.ToString();
                KQC1.ck1 = check1.Text;
                KQC1.ck2 = check2.Text;
                KQC1.ck3 = check3.Text;
                KQC1.ck4 = check4.Text;
                KQC1.ck5 = check5.Text;
                KQC1.ck6 = check6.Text;
                KQC1.ck7 = check7.Text;
                KQC1.ck8 = check8.Text;
                KQC1.ck9 = check9.Text;
                KQC1.ck10 = check10.Text;

                string query = "insert into KetQua values ('" + tenlop.Text + "', '" + msv.Text + "', '" + mon.Text + "', " + diem + ")";
                modify.Connand(query);

                KQC1 kQ = new KQC1();
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
    }
}
