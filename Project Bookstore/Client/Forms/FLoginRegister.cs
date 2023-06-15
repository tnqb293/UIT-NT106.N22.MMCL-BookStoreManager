using Client.Class;
using Client.Forms;
using Client.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FLoginRegister : Form
    {
        public FLoginRegister()
        {
            InitializeComponent();
        }
        //Khởi tạo get set cho các thuộc tính có trong FLoginRegister
        private IpConnection ipConnection = new IpConnection();

        private InfoLogin infoLogin;
        //Đây là chức năng hiện form Login bằng nút Login
        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            pnRegister.Visible = false;
            guna2Transition1.HideSync(pnRegister);
        }
        // Đây là chức năng hiện form Register bằng nút CreateAccount
        private void btnCreateAccountLogin_Click(object sender, EventArgs e)
        {
            pnRegister.Visible = true;
            guna2Transition1.ShowSync(pnRegister);
        }
        private void btnCreateAccountRegister_Click(object sender, EventArgs e)
        {
            infoLogin = new InfoLogin();
            infoLogin.username = tbUsernameResgister.Text;
            infoLogin.password = tbPasswordRegister.Text;
            infoLogin.email = tbEmailRegister.Text;
            infoLogin.passwordEncrypt = Encrypt(infoLogin.password);
            infoLogin.repassword = tbReEnterPasswordRegister.Text;

            //Kiểm tra người dùng đã nhập đủ thông tin chưa, nếu chưa thì yêu cầu người dùng nhập lại
            if (tbUsernameResgister != null && string.IsNullOrEmpty(tbUsernameResgister.Text)
                || tbPasswordRegister != null && string.IsNullOrEmpty(tbPasswordRegister.Text)
                || tbEmailRegister != null && string.IsNullOrEmpty(tbEmailRegister.Text))
            {
                this.Invoke(new Action(() => MessageBox.Show("Vui lòng nhập đủ thông tin")));
                return;
            }
            //Kiểm tra người dùng đã nhập xác minh mật khẩu đã đúng hay chưa
            else if (infoLogin.password != infoLogin.repassword)
            {
                this.Invoke(new Action(() => MessageBox.Show("Mật khẩu không khớp với mật khẩu đã nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
            else
            {
                try
                {
                    string message = "register " + infoLogin.username + " " + infoLogin.passwordEncrypt + " " + infoLogin.email;
                    StringBuilder builder = ipConnection.ConnectToServer(message);
                    if (builder.ToString() == "register success")
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Đăng ký thành công")));

                    }
                    else if (builder.ToString() == "username already exist")
                    {
                        //Disconnect();
                        this.Invoke(new Action(() => MessageBox.Show("Tên người dùng đã tồn tại, vui lòng thử tên người dùng khác")));

                    }
                    else if (builder.ToString() == "Error")
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Lỗi bên phía máy chủ")));
                    }
                }
                catch
                {
                    this.Invoke(new Action(() => MessageBox.Show($"Không tìm thấy máy chủ.")));

                }
            }
        }
        //Mã hóa mật khẩu người dùng
        private string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UnicodeEncoding unicode = new UnicodeEncoding();
                byte[] data = md5.ComputeHash(unicode.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            infoLogin = new InfoLogin();
            infoLogin.username = tbUsernameLogin.Text;
            infoLogin.password = tbPasswordLogin.Text;
            infoLogin.passwordEncrypt = Encrypt(tbPasswordLogin.Text);
            // Kiểm tra người dùng đã nhập đủ thông tin chưa
            if (tbUsernameLogin != null && string.IsNullOrEmpty(tbUsernameLogin.Text)
                || tbPasswordLogin != null && string.IsNullOrEmpty(tbPasswordLogin.Text))
            {
                this.Invoke(new Action(() => MessageBox.Show("Vui lòng nhập đủ thông tin")));
                return;
            }
            else
            {
                try
                {
                    string message = "login " + infoLogin.username + " " + infoLogin.passwordEncrypt;
                    // Gửi yêu cầu tới server bằng hàm ConnectToServer với biến message
                    // và biến builder lưu trữ dữ liệu phản hồi từ server 
                    StringBuilder builder = ipConnection.ConnectToServer(message);
                    if (builder.ToString() == "login success")
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Đăng nhập thành công")));
                        FMainCustomer welcome = new FMainCustomer(infoLogin.username);
                        
                        welcome.Show();
                        this.Hide();
                    }
                    else if(builder.ToString() == "login admin success")
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Đăng nhập thành công")));
                        Form welcome = new FMainAdmin(infoLogin.username);
                        welcome.Show();
                        this.Hide();
                    }
                    else if (builder.ToString() == "login failed")
                    {
                        //Disconnect();
                        this.Invoke(new Action(() => MessageBox.Show("Tên người dùng không tồn tại hoặc mật khẩu sai, vui lòng nhập lại")));

                    }
                    else if (builder.ToString() == "Error")
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Lỗi bên phía máy chủ")));
                    }
                }
                catch
                {
                    this.Invoke(new Action(() => MessageBox.Show($"Không tìm thấy máy chủ.")));

                }
            }
        }
        // Cài đặt địa chỉ Ip và port trước khi kết nối tới server
        private void pbSetting_Click(object sender, EventArgs e)
        {
            FSettingsIP fSettingsIP = new FSettingsIP();
            fSettingsIP.Show();
        }
    }
}
