using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KiemTraWinForm
{
    internal class Modify
    {
        public Modify()
        {

        }

        SqlCommand cmd;
        SqlDataReader dr;

        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3)));
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
