using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using Guna.UI2.WinForms;
using Microsoft.Win32;

namespace BookstoreOnline
{
    public partial class Login_Form : Form
    {
        string connectionString = @"Data Source=DESKTOP-OJKQD5I\SQLEXPRESS;Initial Catalog=BookstoreDB;Integrated Security=True";
        public Login_Form()
        {
            InitializeComponent();
        }
        private void btn_LoginRegister_Click(object sender, EventArgs e)
        {
            pn_regis.Visible = false;
            pn_login.Visible = true;
            guna2Transition1.HideSync(pn_regis);
        }

        private void btn_CreateAccountLogin_Click(object sender, EventArgs e)
        {
            pn_regis.Visible = true;
            pn_login.Visible = false;
            guna2Transition1.ShowSync(pn_regis);
        }

        private void btn_CreateAccountRegister_Click(object sender, EventArgs e)
        {
            string username = tb_UsernameRegister.Text;
            string password = tb_PasswordRegister.Text;
            string email = tb_EmailRegister.Text;
            // Kiểm tra thông tin đăng ký
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Kiểm tra tên đăng nhập đã tồn tại chưa
            string query = "select count(*) from Table_User where Username = @username";
            int count = 0;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                connection.Open();
                count = (int)command.ExecuteScalar();
            }
            if (count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Lưu thông tin người dùng mới vào cơ sở dữ liệu
            query = "INSERT INTO Table_User (Username, Password, Email) VALUES (@username, @password, @email)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);
                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_LoginUser_Click(object sender, EventArgs e)
        {
            string username = tb_UsernameLogin.Text;
            string password = tb_PasswordLogin.Text;
            // Validate input fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "SELECT COUNT(*) FROM Table_User WHERE Username = @username AND Password = @password";
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
                Form welcome = new SplashScreenForm();
                welcome.Show();
                this.Hide();               
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCredentials(string username, string password)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\MyApp");
            key.SetValue("Username", username);
            key.SetValue("Password", password);
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MyApp");
            if (key != null)
            {
                string username = (string)key.GetValue("Username");
                string password = (string)key.GetValue("Password");
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    tb_UsernameLogin.Text = username;
                    tb_PasswordLogin.Text = password;
                    tsRememberme.Checked = true;
                }
            }
        }
    }
}
