using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Server.Class
{
    public  class ClientObject
    {
        internal string ID { get; private set; }
        internal NetworkStream stream { get; private set; }
        internal string username { get; private set; }
        internal string[] splitMessage { get; private set; }
        internal InfoBook infoBook { get; private set; }
        internal InfoBuyBook infobuybook { get; private set; }
        internal ChangePassword changepassword { get; private set; }
        internal InfoRecharge recharge { get; private set; }
        internal TcpClient client { get; private set; }
        internal ServerObject server { get; private set; }
        internal ClientObject(TcpClient client, ServerObject server)
        {
            ID = Guid.NewGuid().ToString();
            this.client = client;
            this.server = server;
            server.AddConnection(this);
        }
        internal void Process()
        {
            try
            {
                stream = client.GetStream();
                string message = GetMessage();
                if(checkGetstream(message) == 2)
                {
                    splitMessage = message.Split(' ');
                    string data = server.dataBaseHandler.RegisterDB(splitMessage[1], splitMessage[2], splitMessage[3]);
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 1)
                {
                    splitMessage = message.Split(' ');
                    string data = server.dataBaseHandler.LoginDB(splitMessage[1], splitMessage[2]);
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }

                else if (checkGetstream(message) == 3)
                {
                    splitMessage = message.Split(' ');
                    string data = server.dataBaseHandler.InforDashboardCustomerDB(splitMessage[1]);
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 4)
                {
                    splitMessage = message.Split(new string[] {"request|addbook "}, StringSplitOptions.None);
                    infoBook = new InfoBook();
                    infoBook = JsonConvert.DeserializeObject<InfoBook>(splitMessage[1]);
                    saveImage(infoBook.coverImage, infoBook.bookname);
                    string pathSaveDB = formatPath(infoBook.bookname);
                    string data = server.dataBaseHandler.AddBookAdminDB(infoBook.bookname, infoBook.writername, infoBook.language, infoBook.country, infoBook.price, infoBook.numberofbookssold, pathSaveDB, infoBook.pagenumber, infoBook.isbn, infoBook.index, infoBook.summary, infoBook.yearofpublication);
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 5)
                {
                    splitMessage = message.Split(' ');
                    string data = server.dataBaseHandler.LoadItemBookDB(splitMessage[1]);
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 6)
                {
                    splitMessage = message.Split(new string[] { "request|findabook " }, StringSplitOptions.None);
                    string bookname = splitMessage[1];
                    string data = server.dataBaseHandler.findABookDB(bookname);
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 7)
                {
                    splitMessage = message.Split(new string[] { "request|buybook " }, StringSplitOptions.None);
                    infobuybook = new InfoBuyBook();
                    infobuybook = JsonConvert.DeserializeObject<InfoBuyBook>(splitMessage[1]);
                    string data = server.dataBaseHandler.buyABook(infobuybook);
                    string[] dataSplit = data.Split(',');
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 8)
                {
                    splitMessage = message.Split(new string[] { "request|purchaselistbook " }, StringSplitOptions.None);
                    string data = server.dataBaseHandler.LoadPurchasedBookDB(splitMessage[1]);
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 9)
                {
                    splitMessage = message.Split(new string[] { "request|historylist " }, StringSplitOptions.None);
                    string data = server.dataBaseHandler.LoadHistoryPurchaseBookCustomer(splitMessage[1]);
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 10)
                {
                    changepassword = new ChangePassword();
                    splitMessage = message.Split(new string[] { "request|changepassword " }, StringSplitOptions.None);
                    changepassword = JsonConvert.DeserializeObject<ChangePassword>(splitMessage[1]);
                    string data = server.dataBaseHandler.ChangePasswordDB(changepassword.username, changepassword.oldpassword, changepassword.newpassword);
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 11)
                {
                    recharge = new InfoRecharge();
                    splitMessage = message.Split(new string[] { "request|recharge " }, StringSplitOptions.None);
                    recharge = JsonConvert.DeserializeObject<InfoRecharge>(splitMessage[1]);
                    string data = server.dataBaseHandler.RechargeDB(recharge.username, recharge.namecard, recharge.valuecard, recharge.datetime, recharge.serinumber, recharge.cardnumber);
                    string[] splitData = data.Split(',');
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 12)
                {
                    splitMessage = message.Split(new string[] { "request|moneyCustomer " }, StringSplitOptions.None);
                    username = splitMessage[1];
                    string data = server.dataBaseHandler.MoneyDB(username);
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 13)
                {
                    splitMessage = message.Split(new string[] { "request|dashboardadmin " }, StringSplitOptions.None);
                    string data = server.dataBaseHandler.InforDashboardAdminDB();
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 14)
                {
                    splitMessage = message.Split(new string[] { "request|editbook " }, StringSplitOptions.None);
                    infoBook = new InfoBook();
                    string oldnamebook = splitMessage[1];
                    infoBook = JsonConvert.DeserializeObject<InfoBook>(splitMessage[2]);
                    saveImage(infoBook.coverImage, infoBook.bookname);
                    string pathSaveDB = formatPath(infoBook.bookname);
                    string data = server.dataBaseHandler.EditBookDB(oldnamebook, infoBook.bookname, infoBook.writername, infoBook.language, infoBook.country, infoBook.price, infoBook.numberofbookssold, pathSaveDB, infoBook.pagenumber, infoBook.isbn, infoBook.index, infoBook.summary, infoBook.yearofpublication);
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 15)
                {
                    string data = server.dataBaseHandler.InfoCustomer();
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
                else if(checkGetstream(message) == 16)
                {
                    splitMessage = message.Split(new string[] { "request|infodetailcustomer " }, StringSplitOptions.None);
                    string data = server.dataBaseHandler.InfoDetailCustomer(Int32.Parse(splitMessage[1]));
                    server.SendMessage(data, this);
                    server.RemoveConnection(this.ID);
                    Close();
                }
            }
            catch
            {
                return;
            }
        }
        public void saveImage(byte[] coverImage, string bookname)
        {
            using (MemoryStream ms = new MemoryStream(coverImage))
            {
                Image image = Image.FromStream(ms);
                string path = formatPath(bookname);
                image.Save(path);
            }
        }
        public string formatPath (string bookname)
        {
            string replacement = "";
            string pattern = "[^a-zA-Z0-9]+";
            string output = Regex.Replace(bookname, pattern, replacement);
            return @"F:\NT106\UIT-NT106.N22.MMCL-BookStoreManager\Project Bookstore\Server\Images\" + output + ".jpg";
        }
        internal int checkGetstream(string message)
        {
            string[] lengthBytes = message.Split(' ');
            string lastmessage = lengthBytes[0];
            switch(lastmessage)
            {
                case "login":
                    return 1;
                case "register":
                    return 2;
                case "request|dashboardcustomer":
                    return 3;
                case "request|addbook":
                    return 4;
                case "itembook":
                    return 5;
                case "request|findabook":
                    return 6;
                case "request|buybook":
                    return 7;
                case "request|purchaselistbook":
                    return 8;
                case "request|historylist":
                    return 9;
                case "request|changepassword":
                    return 10;
                case "request|recharge":
                    return 11;
                case "request|moneyCustomer":
                    return 12;
                case "request|dashboardadmin":
                    return 13;
                case "request|editbook":
                    return 14;
                case "request|listinfocustomer":
                    return 15;
                case "request|infodetailcustomer":
                    return 16;
                default:
                    return 17;
            }
        }

        //Nhận message từ phía client
        private string GetMessage()
        {
            int length;
            StringBuilder builder;
            do
            {
                byte[] receiveBytes = new byte[1024 * 1024 * 50];
                builder = new StringBuilder();
                length = stream.Read(receiveBytes, 0, receiveBytes.Length);
                builder.Append(Encoding.Unicode.GetString(receiveBytes, 0, length));
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
