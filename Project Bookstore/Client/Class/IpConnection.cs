using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Class
{
    public class IpConnection
    {
        internal TcpClient client { get; set; }
        internal NetworkStream stream { get; set; }
        internal readonly IPAddress ipAddr = IPAddress.Parse("172.16.1.22");
        private readonly int port = 8888;
        internal void receiveMessage()
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
                            builder.Append(Encoding.Unicode.GetString(bytes, 0 , length));
                        } while (stream.DataAvailable);
                    }
                    catch
                    {
                        Disconnect();
                        MessageBox.Show("Không thể giao tiếp được với máy chủ, vui lòng thử lại sau.");
                        Environment.Exit(0);
                    }
                }
            }
            catch
            {

            }
        }
        internal void Disconnect()
        {
            if(stream != null)
                stream.Close();
            if (client != null)
                client.Close();
        }
        internal StringBuilder messageFromServer(string message)
        {
            StringBuilder builder;
            int length;
            client = new TcpClient();
            client.Connect(ipAddr, port);
            stream = client.GetStream();
            byte[] bytes = Encoding.Unicode.GetBytes(message);
            builder = new StringBuilder();
            stream.Write(bytes, 0, bytes.Length);
            do
            {
                byte[] receiveBytess = new byte[1024];

                length = stream.Read(receiveBytess, 0, receiveBytess.Length);
                builder.Append(Encoding.Unicode.GetString(receiveBytess, 0, length));
            } while (stream.DataAvailable);
            return builder;
        }

        internal List<InfoBookList> messageFromServerbyte(string message)
        {
            List<InfoBookList> infoBookLists = new List<InfoBookList>();
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                StringBuilder builder = new StringBuilder();
                int length;
                client = new TcpClient();
                client.Connect(ipAddr, port);
                stream = client.GetStream();
                byte[] bytes = Encoding.Unicode.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);
                byte[] receive = new byte[1024];
                do
                {
                    byte[] receiveBytes = new byte[1024];
                    length = stream.Read(receiveBytes, 0, receiveBytes.Length);
                    receive = receive.Concat(receiveBytes).ToArray();
                } while (stream.DataAvailable);
                infoBookLists = (List<InfoBookList>)formatter.Deserialize(new MemoryStream(receive));
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            return infoBookLists;
        }
    }
    
}
