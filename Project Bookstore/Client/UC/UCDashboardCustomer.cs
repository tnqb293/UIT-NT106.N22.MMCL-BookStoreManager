using Client.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Client.FLoginRegister;

namespace Client.UC
{
    public partial class UCDashboardCustomer : UserControl
    {
        public UCDashboardCustomer(string user)
        {
            InitializeComponent();
            username = user;
        }
        TcpClient client { get; set; }
        NetworkStream stream { get; set; }
        private readonly IPAddress ipAddr = IPAddress.Parse("192.168.1.10");
        private readonly int port = 8888;
        public Thread receiveThread { get; set; }
        public string username { get; set; }
        private void btnExitDashboardCustomer_Click(object sender, EventArgs e)
        {
            //Disconnect();
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
        private void pnAmountPaid_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UCDashboardCustomer_Load(object sender, EventArgs e)
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
                string message = username + " dashboardcustomer";
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
                lbNumberOfBooksPurchase.Text = dataSplit[2];
                lbAmountPaid.Text = dataSplit[1];
                receiveThread = new Thread(new ThreadStart(receiveMessage));
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)));

            }
        }
    }

}
