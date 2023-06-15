using Client.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Client.Class
{
    //Class IpConnection có nhiệm vụ thiết lập kết nối với máy chủ, gửi yêu cầu
    // và nhận phản hồi từ máy chủ
    public class IpConnection
    {
        TcpClient client { get; set; }
        NetworkStream stream { get; set; }
        IPAddress ipAddr { get; set; }
        int port { get; set; }
        // Biến xmlSerializer giúp lưu địa chỉ ip và port mà người dùng nhập, vào file xml
        public XmlSerializer xmlSerializer { get; set; }
        public FileStream fs { get; set; }
        //Hàm Disconnnect có nhiệm vụ ngắt kết nối tới máy chủ
        internal void Disconnect()
        {
            if(stream != null)
                stream.Close();
            if (client != null)
                client.Close();
        }
        // Cài đặt địa chỉ ip và port rồi lưu chúng vào file .xml và kết nối với server,
        // gửi yêu cầu và nhận phản hồi từ phía server
        #region desirializeSettings

        internal StringBuilder ConnectToServer(string message)
        {
            StringBuilder builder;
            int length;
            try
            {
                try
                {
                    xmlSerializer = new XmlSerializer(typeof(FSettingsIP.Settings));
                    fs = new FileStream("settings.xml", FileMode.OpenOrCreate);
                    FSettingsIP.Settings desSettings = (FSettingsIP.Settings)xmlSerializer.Deserialize(fs);
                    ipAddr = IPAddress.Parse(desSettings.ipAdd);
                    port = desSettings.port;
                }
                catch
                {
                    ipAddr = IPAddress.Parse("172.16.0.192");
                    port = 8888;
                }
                finally
                {
                    fs.Close();
                }
                client = new TcpClient();
                client.Connect(ipAddr, port);
                stream = client.GetStream();
                byte[] bytes = Encoding.Unicode.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);
                do
                {
                    byte[] receiveBytes = new byte[1024 * 1024 * 10];
                    builder = new StringBuilder();
                    length = stream.Read(receiveBytes, 0, receiveBytes.Length);
                    builder.Append(Encoding.Unicode.GetString(receiveBytes, 0, length));
                } while (stream.DataAvailable);
                return builder;
            }
            catch(Exception ex)
            {
                Disconnect();
                return null;
                
            }
            
        }
        #endregion
    } 
}
