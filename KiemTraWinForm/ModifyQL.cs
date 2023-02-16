using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraWinForm
{
    internal class ModifyQL
    {
        public ModifyQL()
        {

        }

        SqlCommand cmd;
        SqlDataReader dr;

        public List<TaiKhoanQL> TaiKhoans(string query)
        {
            List<TaiKhoanQL> taiKhoans = new List<TaiKhoanQL>();
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    taiKhoans.Add(new TaiKhoanQL(dr.GetString(0), dr.GetString(1)));
                }
                con.Close();
            }

            return taiKhoans;
        }

        public void Connand(string query)
        {
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
