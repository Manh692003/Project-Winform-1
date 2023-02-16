using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KiemTraWinForm
{
    internal class Connection
    {
        private static string con = @"Data Source=DESKTOP-BNUOIPK;Initial Catalog=KIEMTRACUOIKY;Integrated Security=True";
        
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(con);
        }
    }
}
