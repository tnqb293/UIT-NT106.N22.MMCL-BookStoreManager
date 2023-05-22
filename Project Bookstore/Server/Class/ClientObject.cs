using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
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
        internal string[] InforUsernameDashboard { get; private set; }
        internal string[] addBookInfo { get; set; }
        internal InfoBook infoBook { get; private set; }
        internal string password { get; private set; }
        internal string email { get; private set; }
        internal TcpClient client { get; private set; }
        internal ServerObject server { get; private set; }
        internal string inforDashboardCustomer { get; private set; }
        internal ClientObject(TcpClient client, ServerObject server)
        {
            ID = Guid.NewGuid().ToString();
            this.client = client;
            this.server = server;
            server.AddConnection(this);
        }
        //internal void ReceiveMessage()
        //{
        //    stream = client.GetStream();
        //}
        //internal string Process()
        //{
        //    stream = client.GetStream();
        //    return GetMessage();
        //}
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
                        server.SendMessage("register success", this);
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

                else if (checkGetstream(message) == 3)
                {
                    InforUsernameDashboard = message.Split(' ');
                    username = InforUsernameDashboard[0];
                    server.SendMessage(server.dataBaseHandler.InforDashboardCustomerDB(username), this);
                }
                else if(checkGetstream(message) == 4)
                {
                    addBookInfo = message.Split(new string[] {"  "}, StringSplitOptions.None);
                    infoBook = new InfoBook();
                    infoBook.bookname = addBookInfo[0];
                    infoBook.writername = addBookInfo[1];
                    infoBook.category = addBookInfo[2];
                    infoBook.country = addBookInfo[3];
                    infoBook.price = Int32.Parse(addBookInfo[4]);
                    infoBook.numberOfBookRemaining = Int32.Parse(addBookInfo[5]);
                    infoBook.coverImage = addBookInfo[6];
                    if(server.dataBaseHandler.AddBookAdminDB(infoBook.bookname, infoBook.writername, infoBook.category, infoBook.country, infoBook.price, infoBook.numberOfBookRemaining, infoBook.coverImage) == "add book success")
                    {
                        server.SendMessage("add book success", this);
                    }
                    else
                    {
                        server.SendMessage(server.dataBaseHandler.AddBookAdminDB(infoBook.bookname, infoBook.writername, infoBook.category, infoBook.country, infoBook.price, infoBook.numberOfBookRemaining, infoBook.coverImage), this);
                        Close();
                    }
                }
                else if(checkGetstream(message) == 5)
                {
                    if(server.dataBaseHandler.LoadItemBook() != "Error from server")
                    server.SendMessage(server.dataBaseHandler.LoadItemBook(), this);
                    else
                    {
                        server.SendMessage(server.dataBaseHandler.LoadItemBook(), this);
                        Close();
                    }
                }
            }
            catch
            {
                return;
            }
        }
        internal Image stringToImage(string strImage)
        {
            byte[] bytes = Encoding.Default.GetBytes(strImage);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);
            return img;
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
                case "dashboardcustomer":
                    return 3;
                case "addbook":
                    return 4;
                case "itembook":
                    return 5;
                default:
                    return 6;
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
