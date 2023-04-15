using Bookstore__main.Class;
using Bookstore__main.FormsBookstore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bookstore__main
{
    public partial class LoginRegisterForm : Form
    {
        public LoginRegisterForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Hàm này có tác dụng:
        /// Khi click vào Login ở panel Register thì panel Login sẽ được hiển thị và 
        /// panel Register sẽ được giấu đi, có hiệu ứng chuyển form là guna2Transition1 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoginRegister_Click_1(object sender, EventArgs e)
        {
            pnRegister.Visible = false;
            guna2Transition1.HideSync(pnRegister);
        }
        /// <summary>
        /// Khi click vào Create Account ở panel Login thì panel Register sẽ được hiển thị
        /// và panel Login sẽ được giấu đi, có hiệu ứng chuyển form là guna2Transtition2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAccountLogin_Click(object sender, EventArgs e)
        {
            pnRegister.Visible = true;
            guna2Transition1.ShowSync(pnRegister);
        }

        private void btnCreateAccountRegister_Click(object sender, EventArgs e)
        {
            string username = tbUsernameResgister.Text;
            string password = tbPasswordRegister.Text;
            string repassword = tbReEnterPasswordRegister.Text;
            string email = tbEmailRegister.Text;
            if(password != repassword)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                CreateAccount createAccount = new CreateAccount();
                createAccount.createAccount(username, password, email);
            }

        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsernameLogin.Text;
            string password = tbPasswordLogin.Text;
            LoginAccount loginAccount = new LoginAccount();
            if (loginAccount.loginAccount(username, password))
            {
                Form welcome = new SplashScreenForm();
                welcome.Show();
                this.Hide();
                loginAccount.SaveCredentials(username, password);
            }
            else
                return;
            
            
            
        }

        private void LoginRegisterForm_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\MyApp");
            if (key != null)
            {
                string username = (string)key.GetValue("Username");
                string password = (string)key.GetValue("Password");
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    tbUsernameLogin.Text = username;
                    tbPasswordLogin.Text = password;
                    tsRememberMe.Checked = true;
                }
            }
        }
    }
}
