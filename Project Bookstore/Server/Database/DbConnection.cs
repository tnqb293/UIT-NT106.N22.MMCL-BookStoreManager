using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Database
{

    public class DbConnection
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Database\Database.mdf"";Integrated Security=True;Pooling=True";
        public SqlConnection sqlConnection = new SqlConnection(connectionString);
        internal void ConnectionOpen()
        {
            sqlConnection.Open();
        }
        internal void ConnectionClose()
        {
            sqlConnection.Close();
        }
    }
}
