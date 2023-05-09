using Server.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Class
{
    public class DBHandler
    {
        DbConnection connection = new DbConnection();
        internal string RegisterDB(string username,string password, string email)
        {
            try
            {
                connection.ConnectionOpen();
                //Kiểm tra username đăng ký trong db đã có username tồn tại chưa
                string request = "SELECT COUNT(*) From Customer WHERE Username = @username";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                int count = (int)command.ExecuteScalar();
                if (count > 1)
                {
                    connection.ConnectionClose();
                    return "username already exist";
                }
                else
                {
                    request = "INSERT INTO Customer (Username, Password, Email) VALUES (@username, @password, @email)";
                    command = new SqlCommand(request, connection.sqlConnection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.ExecuteNonQuery();
                    connection.ConnectionClose();
                    return "register success";
                }
            }
            catch
            {
                return "Error from server";
            }
        }
        
        internal string LoginDB(string username, string password)
        {
            try
            {
                connection.ConnectionOpen();
                string request = "select count(*) from Customer where Username = @username and Password = @password";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int count = (int)command.ExecuteScalar();
                if(count > 0)
                {
                    connection.ConnectionClose();
                    return "login success";
                }
                else
                {
                    connection.ConnectionClose();
                    return "login failed";
                }
               
            }
            catch
            {
                return "Error from server";
            }
        }
    }
}
