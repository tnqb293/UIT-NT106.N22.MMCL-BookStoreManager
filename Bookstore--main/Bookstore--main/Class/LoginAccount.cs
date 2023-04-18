using Bookstore__main.FormsBookstore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore__main.Class
{
    internal class LoginAccount
    {
        string connectionString = "Data Source=LAPTOP-5OR18CU3;Initial Catalog=DBBookstore;Integrated Security=True";
        public bool loginAccount(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhâp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string query = "select count(*) from Account where Username = @username and Password = @password";
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                count = (int)command.ExecuteScalar();
            }
            if (count > 0)
            {
                MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveCredentials(username, password);
                return true;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void SaveCredentials(string username, string password)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\MyApp");
            key.SetValue("Username", username);
            key.SetValue("Password", password);
        }
    }
}
