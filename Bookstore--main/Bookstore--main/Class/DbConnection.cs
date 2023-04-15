using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore__main.Class
{
    internal class DbConnection
    {
        private SqlConnection connection = new SqlConnection();
        public DbConnection()
        {
            string connectionString = "";
        }
        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection.Close(); 
        }
        public SqlCommand CreateCommand()
        {
            return connection.CreateCommand();
        }
    }
}
