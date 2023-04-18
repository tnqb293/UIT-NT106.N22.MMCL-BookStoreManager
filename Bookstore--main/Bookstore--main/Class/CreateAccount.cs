using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bookstore__main.Class
{
    internal class CreateAccount
    {
        string connectionString = "Data Source=LAPTOP-5OR18CU3;Initial Catalog=DBBookstore;Integrated Security=True";
        public void createAccount(string username, string password, string email)
        {
            //Kiểm tra thông tin nhập có bị thiếu không
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Câu truy vấn kiểm tra tên đăng nhập đã tồn tại chưa
       
            string query = "select count(*) from Account where Username = @username";
            int count = 0;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                connection.Open();
                count = (int)command.ExecuteScalar();
            }
            if(count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Lưu thông tin người dùng mới vào cơ sở dữ liệu
            query = "insert into Account (Username, Password, Email, isAdmin) values (@username, @password, @email, 0)";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if(result > 0)
                {
                    MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại.", "Lỗi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
