using Client.UC;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client.Forms
{
    public partial class FMainCustomer : Form
    {
        private TcpClient client { get; set; }
        private NetworkStream stream { get; set; }
        private readonly IPAddress ipAddr = IPAddress.Parse("192.168.1.10");
        private readonly int port = 8888;
        public Thread receiveThread { get; set; }
        public class InfoUser
        {
            public string username { get; set; }
            public int money { get; set; }
            public Thread receiveThread { get; set; }
        }
        InfoUser info = new InfoUser();
        public FMainCustomer(string user)
        {
            InitializeComponent();
            info.username = user;

        }
        private void pnContentAdmin_Paint(object sender, PaintEventArgs e)
        {
            UCDashboardCustomer uCDashboardCustomer = new UCDashboardCustomer(info.username);
            addUserControl(uCDashboardCustomer);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnContentCustomer.Controls.Clear();
            pnContentCustomer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void receiveMessage()
        {
            StringBuilder builder;
            int length;
            try
            {
                while (true)
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
                        //Environment.Exit(0);
                    }
                }
            }
            catch
            {

            }
        }
        private void Disconnect()
        {
            if (stream != null)
            {
                stream.Close();
            }
            if (client != null)
            {
                client.Close();
            }
        }
        private void FMainCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                string data;
                string[] dataSplit;
                StringBuilder builder;
                int length;
                client = new TcpClient();
                client.Connect(ipAddr, port);
                stream = client.GetStream();
                string message = "flinta" + " dashboardcustomer";
                byte[] bytes = Encoding.Unicode.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);
                do
                {
                    byte[] receiveBytes = new byte[1024];
                    builder = new StringBuilder();
                    length = stream.Read(receiveBytes, 0, receiveBytes.Length);
                    builder.Append(Encoding.Unicode.GetString(receiveBytes, 0, length));
                } while (stream.DataAvailable);
                data = builder.ToString();
                dataSplit = data.Split(' ');
                lbNameCustomer.Text = "flinta";
                lbMoney.Text = dataSplit[0];
                receiveThread = new Thread(new ThreadStart(receiveMessage));
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));

            }
        }
        private void pnControlCustomer_Paint(object sender, PaintEventArgs e)
        {
            //try
            //{
            //    string data;
            //    string[] dataSplit;
            //    StringBuilder builder;
            //    int length;
            //    client = new TcpClient();
            //    client.Connect(ipAddr, port);
            //    stream = client.GetStream();
            //    string message = "flinta" + " dashboardcustomer";
            //    byte[] bytes = Encoding.Unicode.GetBytes(message);
            //    stream.Write(bytes, 0, bytes.Length);
            //    do
            //    {
            //        byte[] receiveBytes = new byte[1024];
            //        builder = new StringBuilder();
            //        length = stream.Read(receiveBytes, 0, receiveBytes.Length);
            //        builder.Append(Encoding.Unicode.GetString(receiveBytes, 0, length));
            //    } while (stream.DataAvailable);
            //    data = builder.ToString();
            //    dataSplit = data.Split(' ');
            //    lbNameCustomer.Text = "flinta";
            //    lbMoney.Text = dataSplit[0];
            //    receiveThread = new Thread(new ThreadStart(receiveMessage));
            //    receiveThread.IsBackground = true;
            //    receiveThread.Start();
            //}
            //catch
            //{
            //    this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));

            //}
        }
    }
}
