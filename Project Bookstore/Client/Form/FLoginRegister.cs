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
        TcpClient client { get; set; }
        NetworkStream stream { get; set; }
        IPAddress ipAddr = IPAddress.Parse("192.168.3.251");
        int port = 8888;
        string username { get; set; }
        string password { get; set; }
        string email { get; set; }
        string repassword { get; set; }
        Thread receiveThread { get; set; }
        string passwordEncrypt { get; set; }
        
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
        // Hàm receiveMessage nhận message từ phía server gửi về
        private void receiveMessage()
        {
            StringBuilder builder;
            int length;
            try
            {
                while(true)
                {
                    try
                    {
                        do
                        {
                            byte[] bytes = new byte[1024];
                            builder = new StringBuilder();
                            length = stream.Read(bytes, 0, bytes.Length);
                            builder.Append(Encoding.Unicode.GetString(bytes, 0, length));
                        }
                        while (stream.DataAvailable);
                    }
                    catch
                    {
                        Disconnect();
                        MessageBox.Show("Không thể giao tiếp được với server, vui lòng thử lại sau");
                        Environment.Exit(0);
                    }
                }
            }
            catch
            {
                
            }
        }
        //Ngắt kết nối với server
        private void Disconnect()
        {
            if(stream != null)
            {
                stream.Close();
            }
            if(client != null)
            {
                client.Close();
            }
        }
        //
        private void btnCreateAccountRegister_Click(object sender, EventArgs e)
        {
            username = tbUsernameResgister.Text;
            password = tbPasswordRegister.Text;
            email = tbEmailRegister.Text;
            passwordEncrypt = Encrypt(password);
            repassword = tbReEnterPasswordRegister.Text;
            //Kiểm tra người dùng đã nhập đủ thông tin chưa, nếu chưa thì yêu cầu người dùng nhập lại
            if (tbUsernameResgister != null && string.IsNullOrEmpty(tbUsernameResgister.Text)
                || tbPasswordRegister != null && string.IsNullOrEmpty(tbPasswordRegister.Text)
                || tbEmailRegister != null && string.IsNullOrEmpty(tbEmailRegister.Text))
            {
                this.Invoke(new Action(() => MessageBox.Show("Vui lòng nhập đủ thông tin")));
                return;
            }
            //Kiểm tra người dùng đã nhập xác minh mật khẩu đã đúng hay chưa
            else if (password != repassword)
            {
                this.Invoke(new Action(() => MessageBox.Show("Mật khẩu không khớp với mật khẩu đã nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
            else
            {
                StringBuilder builder;
                int length;
                try
                {
                    client = new TcpClient();
                    client.Connect(ipAddr, port);
                    stream = client.GetStream();
                    string message = username + " " + passwordEncrypt + " " + email + " register";
                    byte[] bytes = Encoding.Unicode.GetBytes(message);
                    stream.Write(bytes, 0, bytes.Length);
                    do
                    {
                        byte[] receiveBytes = new byte[1024];
                        builder = new StringBuilder();
                        length = stream.Read(receiveBytes, 0, receiveBytes.Length);
                        builder.Append(Encoding.Unicode.GetString(receiveBytes, 0, length));
                    } while (stream.DataAvailable);
                    if (builder.ToString() == "register success")
                    {
                        receiveThread = new Thread(new ThreadStart(receiveMessage));
                        receiveThread.IsBackground = true;
                        receiveThread.Start();
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
                    this.Invoke(new Action(() => MessageBox.Show($"Không tìm thấy máy chủ {ipAddr}.")));

                }
            }
        }
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
            username = tbUsernameLogin.Text;
            password = tbPasswordLogin.Text;
            passwordEncrypt = Encrypt(tbPasswordLogin.Text);
            if (tbUsernameLogin != null && string.IsNullOrEmpty(tbUsernameLogin.Text)
                || tbPasswordLogin != null && string.IsNullOrEmpty(tbPasswordLogin.Text))
            {
                this.Invoke(new Action(() => MessageBox.Show("Vui lòng nhập đủ thông tin")));
                return;
            }
            else
            {
                StringBuilder builder;
                int length;
                try
                {
                    //ipAddr = IPAddress.Parse("192.168.1.10");
                    //port = 8888;
                    client = new TcpClient();
                    client.Connect(ipAddr, port);
                    stream = client.GetStream();
                    string message = username + " " + passwordEncrypt + " login";
                    byte[] bytes = Encoding.Unicode.GetBytes(message);
                    stream.Write(bytes, 0, bytes.Length);
                    do
                    {
                        byte[] receiveBytes = new byte[1024];
                        builder = new StringBuilder();
                        length = stream.Read(receiveBytes, 0, receiveBytes.Length);
                        builder.Append(Encoding.Unicode.GetString(receiveBytes, 0, length));
                    } while (stream.DataAvailable);
                    if (builder.ToString() == "login success")
                    {
                        receiveThread = new Thread(new ThreadStart(receiveMessage));
                        receiveThread.IsBackground = true;
                        receiveThread.Start();
                        this.Invoke(new Action(() => MessageBox.Show("Đăng nhập thành công")));

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
                    this.Invoke(new Action(() => MessageBox.Show($"Không tìm thấy máy chủ {ipAddr}.")));

                }
            }
        }

    }
}
