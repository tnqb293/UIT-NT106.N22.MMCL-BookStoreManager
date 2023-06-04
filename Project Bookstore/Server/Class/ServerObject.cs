using Server.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Server.Class
{
    public class ServerObject
    {
        internal TcpListener listener { get; private set; }
        public List<ClientObject> clients = new List<ClientObject>();
<<<<<<< HEAD
        internal string IPAddr;
        internal int port;
        internal XmlSerializer xmlSerializer { get; set; }
        internal FileStream fs { get; private set; }
=======
        internal string IPAddr = "172.30.159.54";
        internal int port = 8888;
>>>>>>> 1f2fface7cc32121abf3fc0f11ccd2bf8df68dc0
        public DBHandler dataBaseHandler = new DBHandler();
        internal void AddConnection(ClientObject client)
        {
            try
            {
                clients.Add(client);
            }
            catch
            {
                return;
            }
        }
        internal void RemoveConnection(string id)
        {
            try
            {
                ClientObject client = clients.FirstOrDefault(c => c.ID == id);
                if (client != null)
                {
                    clients.Remove(client);
                }
            }
            catch(Exception ex)
            {
                return;
            }
        }
        internal void Disconnect()
        {
            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].Close();
            }
            listener.Stop();
            Environment.Exit(0);
        }
        internal void SendMessage(string message, ClientObject client)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.stream.Write(data, 0, data.Length);
        }
        internal void Listen()
        {
            try
            {
                SelectServer(out IPAddr, out port);
                listener = new TcpListener(IPAddress.Parse(IPAddr), port);
                listener.Start();
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    ClientObject clientObj = new ClientObject(client, this);
                    Thread clientThread = new Thread(new ThreadStart(clientObj.Process));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch
            {
                return;
            }
        }
        internal void SelectServer(out string IPAddr, out int port)
        {
            xmlSerializer = new XmlSerializer(typeof(FSetting.Settings));
            fs = new FileStream("settings.xml", FileMode.OpenOrCreate);
            try
            {
                FSetting.Settings desSettings = (FSetting.Settings)xmlSerializer.Deserialize(fs);
                IPAddr = desSettings.ipaddr;
                port = desSettings.port;
            }
            catch
            {
                var host = Dns.GetHostName();
                var ip = Dns.GetHostEntry(host).AddressList[2];
                IPAddr = Convert.ToString(ip);
                port = 8888;
                FSetting.Settings settings = new FSetting.Settings(IPAddr, port);
                xmlSerializer.Serialize(fs, settings);
                MessageBox.Show("Cannot loads settings, default was set");
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
