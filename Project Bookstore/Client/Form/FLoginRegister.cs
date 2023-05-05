using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
        TcpClient client { get; set; }
        NetworkStream stream { get; set; }
        IPAddress ipAddr { get; set; }
        int port { get; set; }
        string username { get; set; }
        string password { get; set; }
        string email { get; set; }
        Thread receiveThread { get; set; }
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
                        MessageBox.Show("Cannot communicate with server, try again later please");
                        Environment.Exit(0);
                    }
                }
            }
            catch
            {

            }
        }
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

        private void btnCreateAccountRegister_Click(object sender, EventArgs e)
        {
            username = tbUsernameResgister.Text;
            password = tbPasswordRegister.Text;
            email = tbEmailRegister.Text;
            StringBuilder builder;
            int length;
            try
            {
                ipAddr = IPAddress.Parse("172.16.0.201");
                port = 8888;
            }
            catch
            {

            }
            client = new TcpClient();
            client.Connect(ipAddr, port);
            stream = client.GetStream();
            string message = username + " " + password + " " + email;
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            stream.Write(bytes, 0, bytes.Length);
            do
            {
                byte[] receiveBytes = new byte[1024];
                builder = new StringBuilder();
                length = stream.Read(receiveBytes, 0, receiveBytes.Length);
                builder.Append(Encoding.Unicode.GetString(receiveBytes, 0, length));
            } while (stream.DataAvailable);
            if(builder.ToString() == "register success")
            {
                receiveThread = new Thread(new ThreadStart(receiveMessage));
                receiveThread.IsBackground = true;
                receiveThread.Start();
                this.Invoke(new Action(() => MessageBox.Show("Resigter success")));
               
            }
            else if(builder.ToString() == "username already exist")
            {
                //Disconnect();
                this.Invoke(new Action(() => MessageBox.Show("Username already exist, try again")));

            }
            else if (builder.ToString() == "Error")
            {
                this.Invoke(new Action(() => MessageBox.Show("Error from server")));
            }

        }
    }
}
