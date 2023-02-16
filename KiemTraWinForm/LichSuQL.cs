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
using Excel = Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Globalization;

namespace KiemTraWinForm
{
    public partial class LichSuQL : Form
    {
        public static string Lop = string.Empty;

        SqlConnection con;
        SqlCommand cmd;
        String str = @"Data Source=DESKTOP-BNUOIPK;Initial Catalog=KIEMTRACUOIKY;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public LichSuQL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = "select TaiKhoan.Lop, TaiKhoan.MaSV, TaiKhoan.HoTen, KetQua.MonThi, KetQua.Diem " +
                "from TaiKhoan, KetQua, LopHoc " +
                "where TaiKhoan.MaSV = KetQua.TenDangNhap and KetQua.MonThi = N'" + cbb.Text + "' " +
                "group by TaiKhoan.Lop, TaiKhoan.MaSV, TaiKhoan.HoTen, KetQua.MonThi, KetQua.Diem";
            da.SelectCommand = cmd;
            dt.Clear();
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        private void XuatExcel (DataGridView g, string duongdan, string tenfile)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;

            for (int i = 1; i <g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                }
            }

            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XuatExcel(dgv, @"D:\Workspace\HocLapTrinh\Visual C#\KiemTraWinForm\Danh sách kết quả thi môn ", cbb.Text);
            MessageBox.Show("Xuất excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LichSuQL_Load(object sender, EventArgs e)
        {
            
        }
    }
}
