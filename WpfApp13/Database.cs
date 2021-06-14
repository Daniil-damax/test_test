using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WpfApp13
{
    class Database
    {
        public static string connection_string= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danek\source\repos\WpfApp13\WpfApp13\Database1.mdf;Integrated Security=True";
        public static void Insert(string login,string pass)
        {
            SqlConnection connection = new SqlConnection(connection_string);
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string sql = $"INSERT INTO [Pers] (login,pass,date) VALUES ('{login}','{pass}','{time.ToString(format)}')";
            connection.Open();
            SqlCommand comm = new SqlCommand(sql, connection);
            comm.ExecuteNonQuery();
        }


        
    }
}
