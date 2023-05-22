using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace Server.Class
{
    public class ServerObject
    {
        internal static TcpListener listener { get; private set; }
        public List<ClientObject> clients = new List<ClientObject>();
        internal string IPAddr = "172.16.1.22";
        internal int port = 8888;
        internal DBHandler dataBaseHandler = new DBHandler();
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
            catch
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
        internal void SendMessageFormatter(List<InfoBook> infobook, ClientObject client)
        {
            //using(MemoryStream stream = new MemoryStream())
            //{
            //    BinaryFormatter formatter = new BinaryFormatter();
            //    formatter.Serialize(stream, infobook);
            //    byte[] data = stream.ToArray();
            //    client.stream.Write(data, 0, data.Length);
            //}

        }
        internal void Listen()
        {
            try
            {
                listener = new TcpListener(IPAddress.Parse(IPAddr), port);
                listener.Start();
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    ClientObject clientObj = new ClientObject(client, this);
                    Thread clientThread = new Thread(new ThreadStart(clientObj.ProcessRegister));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch
            {
                return;
            }
        }
    }
}
