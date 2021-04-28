using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Login
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connString = @"Server=WINDOWS-EKS4LMU\SQLEXPRESS;Database=HMS;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
