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
    public class IpConnection
    {
        TcpClient client { get; set; }
        NetworkStream stream { get; set; }
        IPAddress ipAddr { get; set; }
        int port { get; set; }
        Thread recieveThread { get; set; }
        public XmlSerializer xmlSerializer { get; set; }
        public FileStream fs { get; set; }
        //internal string receiveMessage()
        //{
        //    StringBuilder builder;
        //    int length;
            
        //    try
        //    {
        //        while (true)
        //        {
        //            try
        //            {
        //                do
        //                {
        //                    byte[] bytes = new byte[1024];
        //                    builder = new StringBuilder();
        //                    length = stream.Read(bytes, 0, bytes.Length);
        //                    builder.Append(Encoding.Unicode.GetString(bytes, 0 , length));
        //                } while (stream.DataAvailable);
        //                return builder.ToString();
        //            }
        //            catch
        //            {
        //                Disconnect();
        //                return "Không thể giao tiếp được với server";
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        Disconnect();
        //        return "Không thể giao tiếp được với server";
        //    }
        //}
        internal void Disconnect()
        {
            if(stream != null)
                stream.Close();
            if (client != null)
                client.Close();
        }
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
        //internal StringBuilder messageFromServer(string message)
        //{
        //    StringBuilder builder;
        //    int length;
        //    //using (FSettingsIP settings = new FSettingsIP())
        //    //{
        //    //    ipAddr = IPAddress.Parse(settings.tbIP.Text);
        //    //    port = Int32.Parse(settings.tbPort.Text);
        //    //}
        //    try
        //    {
        //        while (true)
        //        {
        //            try
        //            {

        //            }
        //        }
        //    }
        //    client = new TcpClient();
        //    client.Connect(ipAddr, port);
        //    stream = client.GetStream();
        //    byte[] bytes = Encoding.Unicode.GetBytes(message);
        //    builder = new StringBuilder();
        //    stream.Write(bytes, 0, bytes.Length);
        //    byte[] buffer = new byte[1024];
        //    length = stream.Read(buffer, 0, buffer.Length);
        //    builder.Append(Encoding.Unicode.GetString(buffer, 0, length));
        //    int byteSize = Int32.Parse(builder.ToString());
        //    builder = new StringBuilder();
        //    //Chuẩn bị số bytes của buffer mà server sẽ gửi
        //    do
        //    {
        //        byte[] receiveBytess = new byte[byteSize];

        //        length = stream.Read(receiveBytess, 0, receiveBytess.Length);
        //        builder.Append(Encoding.Unicode.GetString(receiveBytess, 0, length));
        //    } while (stream.DataAvailable);
        //    return builder;
        //}
        //internal StringBuilder messageFromServer(string message)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    int length;
        //    using (TcpClient client = new TcpClient())
        //    {
        //        client.Connect(ipAddr, port);
        //        using (NetworkStream stream = client.GetStream())
        //        {
        //            byte[] bytes = Encoding.Unicode.GetBytes(message);
        //            stream.Write(bytes, 0, bytes.Length);
        //            do
        //            {
        //                byte[] receiveBytes = new byte[1024];
        //                length = stream.Read(receiveBytes, 0, receiveBytes.Length);
        //                builder.Append(Encoding.Unicode.GetString(receiveBytes, 0, length));
        //            } while (length > 0);
        //        }
        //    }
        //    return builder;
        //}
        //private int sizeBytes(string messsage)
        //{
        //    client = new TcpClient();
        //    client.Connect(ipAddr, port);
        //    stream.
        //}
    }
    
    
}
