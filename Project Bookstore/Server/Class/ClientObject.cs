using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Class
{
    public  class ClientObject
    {
        internal string ID { get; private set; }
        internal NetworkStream stream { get; private set; }
        internal string username { get; private set; }
        internal string[] userNameAndPasswordandEmail { get; private set; }
        internal string[] userNameAndPassword { get; private set; }
        internal string password { get; private set; }
        internal string email { get; private set; }
        internal TcpClient client { get; private set; }
        internal ServerObject server { get; private set; }
        internal ClientObject(TcpClient client, ServerObject server)
        {
            ID = Guid.NewGuid().ToString();
            this.client = client;
            this.server = server;
            server.AddConnection(this);
        }
        internal void ReceiveMessage()
        {
            stream = client.GetStream();
        }
        internal string Process()
        {
            stream = client.GetStream();
            return GetMessage();
        }
        internal void ProcessRegister()
        {
            try
            {
                stream = client.GetStream();
                string message = GetMessage();
                if(checkGetstream(message) == 2)
                {
                    userNameAndPasswordandEmail = message.Split(' ');
                    username = userNameAndPasswordandEmail[0];
                    password = userNameAndPasswordandEmail[1];
                    email = userNameAndPasswordandEmail[2];
                    if (server.dataBaseHandler.RegisterDB(username, password, email) == "register success")
                    {
                        //server.BroadcastMessage(message, this.ID);
                        server.SendMessage(server.dataBaseHandler.RegisterDB(username, password, email), this);
                    }
                    else
                    {
                        server.SendMessage(server.dataBaseHandler.RegisterDB(username, password, email), this);
                        Close();
                    }
                }
                else if(checkGetstream(message) == 1)
                {
                    userNameAndPassword = message.Split(' ');
                    username = userNameAndPassword[0];
                    password = userNameAndPassword[1];
                    if (server.dataBaseHandler.LoginDB(username, password) == "login success")
                    {
                        server.SendMessage(server.dataBaseHandler.LoginDB(username, password), this);
                    }
                    else
                    {
                        server.SendMessage(server.dataBaseHandler.LoginDB(username, password), this);
                        Close();
                    }
                }
            }
            catch
            {
                return;
            }
        }
        internal int checkGetstream(string message)
        {
            string[] lengthBytes = message.Split(' ');
            string lastmessage = lengthBytes[lengthBytes.Length - 1];
            switch(lastmessage)
            {
                case "login":
                    return 1;
                case "register":
                    return 2;
                default:
                    return 3;
            }
        }
        internal void Getstream()
        {
            stream = client.GetStream();
        }
        //Nhận message từ phía client
        private string GetMessage()
        {
            byte[] data = new byte[1024];
            int length;
            StringBuilder builder = new StringBuilder();
            do
            {
                length = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, length));
            }
            while (stream.DataAvailable);
            return builder.ToString();
        }

        internal void Close()
        {
            if (client != null)
                client.Close();
            if (stream != null)
                stream.Close();
        }
    }
}
