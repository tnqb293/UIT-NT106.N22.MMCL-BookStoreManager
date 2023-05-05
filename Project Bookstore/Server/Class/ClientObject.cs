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
            internal void ProcessRegister()
            {
                try
                {
                    stream = client.GetStream();
                    string message = GetMessage();
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
                        //Close();
                    }
                }
                catch
                {
                    return; 
                }
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
