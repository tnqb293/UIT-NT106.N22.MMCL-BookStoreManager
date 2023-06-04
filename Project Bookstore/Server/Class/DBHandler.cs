using Client.Class;
using Newtonsoft.Json;
using Server.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Server.Class
{
    public class DBHandler
    {
        DbConnection connection = new DbConnection();
        static string usernamee;
        internal string RegisterDB(string username,string password, string email)
        {
            try
            {
                connection.ConnectionOpen();
                DateTime date = DateTime.Now;
                //Kiểm tra username đăng ký trong db đã có username tồn tại chưa
                string request = "SELECT COUNT(*) From Customer WHERE TENKH = @username";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    connection.ConnectionClose();
                    return "username already exist";
                }
                else
                {
                    request = "INSERT INTO Customer (TENKH, MATKHAU, Email, NGAYTAO) VALUES (@username, @password, @email, @date)";
                    command = new SqlCommand(request, connection.sqlConnection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@date", date);
                    command.ExecuteNonQuery();
                    connection.ConnectionClose();
                    return "register success";
                }
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        
        internal string LoginDB(string username, string password)
        {
            try
            {
                connection.ConnectionOpen();
                string request = "select count(*) from Customer where TENKH = @username and MATKHAU = @password";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int count = (int)command.ExecuteScalar();
                if(count > 0)
                {
                    if(username == "admin")
                    {
                        connection.ConnectionClose();
                        return "login admin success";
                    }
                    connection.ConnectionClose();
                    return "login success";
                }
                else
                {
                    connection.ConnectionClose();
                    return "login failed";
                }
               
            }
            catch
            {
                return "Error from server";
            }
        }
        public string AddBookAdminDB(string bookname, string writername, string language, string country, int price, int numberofbookssold, string coverImage, int pagenumber, string isbn, string index, string summary, int yearofpublication)
        {
            try
            {
                DateTime datetime = DateTime.Now;
                //saveImage(coverImage);
                connection.ConnectionOpen();
                string request = "INSERT INTO Book (TENSACH, TENTACGIA, NGONNGU, QUOCGIA, GIABIA, SACHDABAN, ANHBIA, SOTRANG, ISBN, MUCLUC, TOMTAT, NAMXUATBAN, NGAYTHEM)" +
                    "VALUES (@bookname, @writername, @language, @country, @price, @numberofbookssold, @coverImage, @pagenumber, @isbn, @index, @summary, @yearofpublication, @datetime)";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@bookname", bookname);
                command.Parameters.AddWithValue("@writername", writername);
                command.Parameters.AddWithValue("@language", language);
                command.Parameters.AddWithValue("@country", country);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@numberofbookssold", numberofbookssold);
                command.Parameters.AddWithValue("@coverImage", coverImage);
                command.Parameters.AddWithValue("@pagenumber", pagenumber);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.Parameters.AddWithValue("@index", index);
                command.Parameters.AddWithValue("@summary", summary);
                command.Parameters.AddWithValue("@yearofpublication", yearofpublication);
                command.Parameters.AddWithValue("@datetime", datetime);
                command.ExecuteNonQuery();
                connection.ConnectionClose();
                return "add book success";
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        internal string InforDashboardCustomerDB(string username)
        {
            try
            {
                connection.ConnectionOpen();
                string request = "select TIENCONDU, TIENDACHI, SACHDAMUA, SOTIENNAP, DIEMTICHLUY from Customer where TENKH = @username";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                InfoDashboardCustomer info = new InfoDashboardCustomer();
                while (reader.Read())
                {
                    info.Money = reader.GetInt32(0);
                    info.AmountPaid = reader.GetInt32(1);
                    info.NumberofBooksPurchase = reader.GetInt32(2);
                    info.Deposits = reader.GetInt32(3);
                    info.Points = reader.GetInt32(4);
                }
                connection.ConnectionClose();
                connection.ConnectionOpen();
                request = "SELECT ROW_NUMBER() OVER (ORDER BY SACHDABAN DESC) AS 'STT', TENSACH,SACHDABAN  FROM Book ORDER BY SACHDABAN DESC OFFSET 0 ROWS FETCH NEXT 20 ROWS ONLY;";
                command = new SqlCommand(request, connection.sqlConnection);
                reader = command.ExecuteReader();
                info.bookCharts = new List<BookChart>();
                while (reader.Read())
                {
                    BookChart bookChart = new BookChart();
                    bookChart.top = Int32.Parse(reader.GetInt64(0).ToString());
                    bookChart.bookname = reader.GetString(1);
                    bookChart.numberofbooksold = reader.GetInt32(2);
                    info.bookCharts.Add(bookChart);
                }
                connection.ConnectionClose();
                connection.ConnectionOpen();
                request = "SELECT ROW_NUMBER() OVER (ORDER BY SACHDAMUA DESC) AS 'STT', TENKH,SACHDAMUA  FROM Customer ORDER BY SACHDAMUA DESC OFFSET 0 ROWS FETCH NEXT 20 ROWS ONLY;";
                command = new SqlCommand(request, connection.sqlConnection);
                reader = command.ExecuteReader();
                info.customerCharts = new List<CustomerChart>();
                while (reader.Read())
                {
                    CustomerChart customerChart = new CustomerChart();
                    customerChart.top = Int32.Parse(reader.GetInt64(0).ToString());
                    customerChart.username = reader.GetString(1);
                    customerChart.numberofbookpurchase = reader.GetInt32(2);
                    info.customerCharts.Add(customerChart);
                }
                connection.ConnectionClose();
                string inforDashboardCustomer = JsonConvert.SerializeObject(info);
                return inforDashboardCustomer;

            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        internal string LoadItemBookDB(string username)
        {
            try
            {
                int iduser = 0;
                List<InfoBook> infoBooks = new List<InfoBook>();
                connection.ConnectionOpen();
                string request = "select MAKH from Customer WHERE TENKH = @username";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    iduser = reader.GetInt32(0);
                }
                connection.ConnectionClose();
                request = "select TENSACH, TENTACGIA, NGONNGU, QUOCGIA, GIABIA, SACHDABAN, ANHBIA, SOTRANG, ISBN, MUCLUC, TOMTAT,NAMXUATBAN from Book where Book.MASACH not in (select BookUserManagement.MASACH from BookUserManagement inner join Book on Book.MASACH = BookUserManagement.MASACH inner join Customer on Customer.MAKH = BookUserManagement.MAKH where BookUserManagement.MAKH = @iduser)";
                connection.ConnectionOpen();
                command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@iduser", iduser);
                using (SqlDataReader reader1 = command.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        InfoBook infoBook = new InfoBook();  
                        infoBook.bookname = reader1.GetString(0);
                        infoBook.writername = reader1.GetString(1);
                        infoBook.language = reader1.GetString(2);
                        infoBook.country = reader1.GetString(3);
                        infoBook.price = reader1.GetInt32(4);
                        infoBook.numberofbookssold = reader1.GetInt32(5);                    
                        infoBook.coverImage = File.ReadAllBytes(reader1.GetString(6));
                        infoBook.pagenumber = reader1.GetInt32(7);
                        infoBook.isbn = reader1.GetString(8);
                        infoBook.index = reader1.GetString(9);
                        infoBook.summary = reader1.GetString(10);
                        infoBook.yearofpublication = reader1.GetInt32(11);
                        infoBooks.Add(infoBook);
                    }
                    string jsonObject = JsonConvert.SerializeObject(infoBooks);
                    connection.ConnectionClose();
                    return jsonObject;
                }

            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        internal string LoadPurchasedBookDB(string username)
        {
            try
            {
                int iduser = 0;
                List<InfoPurchaseBook> infoBooks = new List<InfoPurchaseBook>();
                connection.ConnectionOpen();
                string request = "select MAKH from Customer WHERE TENKH = @username";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    iduser = reader.GetInt32(0);
                }
                connection.ConnectionClose();
                //string request = "select TENSACH, TENTACGIA, NGONNGU, QUOCGIA, GIABIA, SACHDABAN, ANHBIA, SOTRANG, ISBN, MUCLUC, TOMTAT, NAMXUATBAN from Book";
                request = "select TENSACH, TENTACGIA, NGONNGU, QUOCGIA, GIABIA, SACHDABAN, ANHBIA, SOTRANG, ISBN, MUCLUC, TOMTAT,NAMXUATBAN from Book left join BookUserManagement on Book.MASACH = BookUserManagement.MASACH  left join Customer on BookUserManagement.MAKH = Customer.MAKH where BookUserManagement.MAKH = @iduser";
                connection.ConnectionOpen();
                command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@iduser", iduser);
                using (SqlDataReader reader1 = command.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        InfoPurchaseBook infoBook = new InfoPurchaseBook();
                        infoBook.bookname = reader1.GetString(0);
                        infoBook.writername = reader1.GetString(1);
                        infoBook.language = reader1.GetString(2);
                        infoBook.country = reader1.GetString(3);
                        infoBook.price = reader1.GetInt32(4);
                        infoBook.numberofbookssold = reader1.GetInt32(5);
                        infoBook.coverImage = File.ReadAllBytes(reader1.GetString(6));
                        infoBooks.Add(infoBook);
                    }
                    string jsonObject = JsonConvert.SerializeObject(infoBooks);
                    connection.ConnectionClose();
                    return jsonObject;
                }

            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        internal string findABookDB(string bookname)
        {
            try
            {
                InfoBook infobook = new InfoBook();
                connection.ConnectionOpen();
                string request = "select TENSACH, TENTACGIA, NGONNGU, QUOCGIA, GIABIA, SACHDABAN, ANHBIA, SOTRANG, ISBN, MUCLUC, TOMTAT, NAMXUATBAN from Book where TENSACH = @bookname";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@bookname", bookname);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    infobook.bookname = reader.GetString(0);
                    infobook.writername = reader.GetString(1);
                    infobook.language = reader.GetString(2);
                    infobook.country = reader.GetString(3);
                    infobook.price = reader.GetInt32(4);
                    infobook.numberofbookssold = reader.GetInt32(5);
                    infobook.coverImage = File.ReadAllBytes(reader.GetString(6));
                    infobook.pagenumber = reader.GetInt32(7);
                    infobook.isbn = reader.GetString(8);
                    infobook.index = reader.GetString(9);
                    infobook.summary = reader.GetString(10);
                    infobook.yearofpublication = reader.GetInt32(11);
                }
                string jsonObject = JsonConvert.SerializeObject(infobook);
                connection.ConnectionClose();
                return jsonObject;
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        internal string buyABook(InfoBuyBook infobuybook)
        {
            try
            {
                CheckMoneyCustomer saveInfo = new CheckMoneyCustomer();
                connection.ConnectionOpen();
                string request = "select MASACH,GIABIA FROM Book where TENSACH = @bookname";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@bookname", infobuybook.bookname);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    saveInfo.bookId = reader.GetInt32(0);
                    saveInfo.price = reader.GetInt32(1);
                }
                connection.ConnectionClose();
                connection.ConnectionOpen();
                request = "select MAKH,TIENCONDU FROM Customer where TENKH = @username";
                command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", infobuybook.username);
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    saveInfo.money = reader.GetInt32(1);
                    saveInfo.userId = reader.GetInt32(0);
                }
                connection.ConnectionClose();
                if (saveInfo.money < saveInfo.price)
                {
                    connection.ConnectionClose();
                    return "Not enough money";
                }
                else
                {
                    connection.ConnectionOpen();
                    request = "SELECT COUNT (*) FROM BookUserManagement WHERE MAKH = @userid AND MASACH = @bookid";
                    command = new SqlCommand(request, connection.sqlConnection);
                    command.Parameters.AddWithValue("@userid", saveInfo.userId);
                    command.Parameters.AddWithValue("@bookid", saveInfo.bookId);
                    int count = (int)command.ExecuteScalar();
                    if(count > 0)
                    {
                        connection.ConnectionClose();
                        return "Already own";
                    }
                    else
                    {
                        connection.ConnectionClose();
                        connection.ConnectionOpen();
                        int moneyafter = saveInfo.money - saveInfo.price;
                        int rewardPoints = saveInfo.price / 1000;
                        request =
                                "UPDATE Customer SET TIENCONDU = @moneyAfter WHERE TENKH = @username;" +
                                "UPDATE Customer SET SACHDAMUA = SACHDAMUA + 1 WHERE TENKH = @username;" +
                                "UPDATE Customer SET TIENDACHI = TIENDACHI + @price WHERE TENKH = @username;" +
                                "UPDATE Customer SET DIEMTICHLUY = DIEMTICHLUY + @rewardPoints WHERE TENKH = @username;" +
                                "INSERT INTO PurchaseHistory (TENKH, TENSACH, GIATIEN, TGMUA, CONGDIEM) VALUES (@username, @bookname, @price, @datetime, @rewardPoints);" +
                                "UPDATE Book SET SACHDABAN = SACHDABAN + 1 WHERE TENSACH = @bookname;" +
                                "INSERT INTO BookUserManagement (MAKH, MASACH) SELECT Customer.MAKH, Book.MASACH FROM Customer JOIN Book ON Customer.TENKH = @username AND Book.TENSACH = @bookname";
                                
                        command = new SqlCommand(request, connection.sqlConnection);
                        command.Parameters.AddWithValue("@moneyAfter", moneyafter);
                        command.Parameters.AddWithValue("@price", saveInfo.price);
                        command.Parameters.AddWithValue("@username", infobuybook.username);
                        command.Parameters.AddWithValue("@bookname", infobuybook.bookname);
                        command.Parameters.AddWithValue("@datetime", infobuybook.datetime);
                        command.Parameters.AddWithValue("@rewardPoints", rewardPoints);
                        command.ExecuteNonQuery();
                        connection.ConnectionClose();
                        return "Purchase success," + moneyafter.ToString();
                    }                  
                }
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        internal string LoadHistoryPurchaseBookCustomer(string username)
        {
            try
            {
                List<InfoHistoryPurchased> list = new List<InfoHistoryPurchased>();
                connection.ConnectionOpen();
                string request = "SELECT PurchaseHistory.MALSMUAHANG, PurchaseHistory.TENSACH, GIATIEN, TGMUA, CONGDIEM, ANHBIA from PurchaseHistory INNER JOIN Book on Book.TENSACH = PurchaseHistory.TENSACH where PurchaseHistory.TENKH = @username";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    InfoHistoryPurchased item = new InfoHistoryPurchased();
                    item.tradingcode = reader.GetInt32(0);
                    item.bookname = reader.GetString(1);
                    item.price = reader.GetInt32(2);
                    item.datetime = reader.GetDateTime(3);
                    item.getPoint = reader.GetInt32(4);
                    item.imagecover = File.ReadAllBytes(reader.GetString(5));
                    list.Add(item);
                }
                string jsonObject = JsonConvert.SerializeObject(list);
                connection.ConnectionClose();
                return jsonObject;
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        internal string ChangePasswordDB(string username, string oldpassword, string newpassword)
        {
            try
            {
                connection.ConnectionOpen();
                string request = "SELECT COUNT(*) From Customer WHERE TENKH = @username and MATKHAU = @oldpassword";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@oldpassword", oldpassword);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    request = "UPDATE Customer SET MATKHAU = @newpassword WHERE TENKH = @username";
                    command = new SqlCommand(request, connection.sqlConnection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@newpassword", newpassword);
                    command.ExecuteNonQuery();
                    connection.ConnectionClose();
                    return "change password success";
                }
                else
                {
                    connection.ConnectionClose();
                    return "password dose not exist";
                }
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        internal string RechargeDB(string username, string namecard, int valuecard, DateTime datetime, string serinumber, string cardnumber)
        {
            try
            {
                int userid = 0;
                int money = 0;
                connection.ConnectionOpen();
                string request = "SELECT COUNT (*) from RechargeHistory where SOSERI = @serinumber OR SOTHE = @cardnumber";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@serinumber", serinumber);
                command.Parameters.AddWithValue("@cardnumber", cardnumber);
                int count = (int)command.ExecuteScalar();
                if(count > 0)
                {
                    connection.ConnectionClose();
                    return "Card already exist";
                }
                else
                {
                    request = "SELECT MAKH FROM Customer WHERE TENKH = @username";
                    command = new SqlCommand(request, connection.sqlConnection);
                    command.Parameters.AddWithValue("@username", username);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        userid = reader.GetInt32(0);
                    }
                    connection.ConnectionClose();
                    connection.ConnectionOpen();
                    request = "INSERT INTO RechargeHistory(MAKH, MENHGIA, TGNAP, LOAITHE, SOSERI, SOTHE) VALUES (@makh, @menhgia, @tgnap, @loaithe, @soseri, @sothe);" +
                                "UPDATE Customer SET SOTIENNAP = SOTIENNAP + @menhgia WHERE MAKH = @makh;" +
                                "UPDATE Customer SET TIENCONDU = TIENCONDU + @menhgia WHERE MAKH = @makh";
                    command = new SqlCommand(request, connection.sqlConnection);
                    command.Parameters.AddWithValue("@makh", userid);
                    command.Parameters.AddWithValue("@menhgia", valuecard);
                    command.Parameters.AddWithValue("@tgnap", datetime);
                    command.Parameters.AddWithValue("@loaithe", namecard);
                    command.Parameters.AddWithValue("@soseri", serinumber);
                    command.Parameters.AddWithValue("@sothe", cardnumber);
                    command.ExecuteNonQuery();
                    connection.ConnectionClose();
                    connection.ConnectionOpen();
                    request = "SELECT TIENCONDU FROM Customer where MAKH = @userid";
                    command = new SqlCommand(request, connection.sqlConnection);
                    command.Parameters.AddWithValue("@userid", userid);
                    reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        money = reader.GetInt32(0);
                    }

                    connection.ConnectionClose();
                    return "Successful recharge," + money.ToString();
                }
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        internal string MoneyDB(string username)
        {
            try
            {
                int money = 0;
                connection.ConnectionOpen();
                string request = "Select TIENCONDU FROM Customer where TENKH = @username";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                    money = (int)reader.GetInt32(0);
                connection.ConnectionClose();
                return money.ToString();
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }

        }
        internal string InforDashboardAdminDB()
        {
            try
            {
                connection.ConnectionOpen();
                string request = "SELECT SUM (MENHGIA) FROM RechargeHistory";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                InfoDashboardAdmin info = new InfoDashboardAdmin();
                while (reader.Read())
                {
                    info.Revenue = reader.GetInt32(0);
                }
                connection.ConnectionClose();
                connection.ConnectionOpen();
                request = "SELECT SUM (SACHDAMUA) FROM Customer";
                command = new SqlCommand(request, connection.sqlConnection);
                reader = command.ExecuteReader();
                while (reader.Read())
                    info.Booksold = reader.GetInt32(0);
                connection.ConnectionClose();
                connection.ConnectionOpen();
                request = "SELECT COUNT(MAKH) FROM Customer";
                command = new SqlCommand(request, connection.sqlConnection);
                reader = command.ExecuteReader();
                while (reader.Read())
                    info.CustomerNumber = reader.GetInt32(0);
                connection.ConnectionClose();
                connection.ConnectionOpen();
                request = "Select count(MASACH) from Book";
                command = new SqlCommand(request, connection.sqlConnection);
                reader = command.ExecuteReader();
                while (reader.Read())
                    info.NumberOfBookCustomer = reader.GetInt32(0);
                connection.ConnectionClose();
                connection.ConnectionOpen();
                request = "SELECT ROW_NUMBER() OVER (ORDER BY SACHDABAN DESC) AS 'STT', TENSACH,SACHDABAN  FROM Book ORDER BY SACHDABAN DESC OFFSET 0 ROWS FETCH NEXT 20 ROWS ONLY;";
                command = new SqlCommand(request, connection.sqlConnection);
                reader = command.ExecuteReader();
                info.bookCharts = new List<BookChartAdmin>();
                while (reader.Read())
                {
                    BookChartAdmin bookChart = new BookChartAdmin();
                    bookChart.top = Int32.Parse(reader.GetInt64(0).ToString());
                    bookChart.bookname = reader.GetString(1);
                    bookChart.numberofbooksold = reader.GetInt32(2);
                    info.bookCharts.Add(bookChart);
                }
                connection.ConnectionClose();
                connection.ConnectionOpen();
                request = "SELECT ROW_NUMBER() OVER (ORDER BY SACHDAMUA DESC) AS 'STT', TENKH,SACHDAMUA  FROM Customer ORDER BY SACHDAMUA DESC OFFSET 0 ROWS FETCH NEXT 20 ROWS ONLY;";
                command = new SqlCommand(request, connection.sqlConnection);
                reader = command.ExecuteReader();
                info.customerCharts = new List<CustomerChartAdmin>();
                while (reader.Read())
                {
                    CustomerChartAdmin customerChart = new CustomerChartAdmin();
                    customerChart.top = Int32.Parse(reader.GetInt64(0).ToString());
                    customerChart.username = reader.GetString(1);
                    customerChart.numberofbookpurchase = reader.GetInt32(2);
                    info.customerCharts.Add(customerChart);
                }
                connection.ConnectionClose();
                string inforDashboardCustomer = JsonConvert.SerializeObject(info);
                return inforDashboardCustomer;
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        public string EditBookDB(string oldnamebook, string bookname, string writername, string language, string country, int price, int numberofbookssold, string coverImage, int pagenumber, string isbn, string index, string summary, int yearofpublication)
        {
            try
            {
                connection.ConnectionOpen();
                int idbook = 0;
                string request = "select MASACH from Book where TENSACH = @bookname";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@bookname", oldnamebook);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    idbook = reader.GetInt32(0);
                }
                connection.ConnectionClose();
                connection.ConnectionOpen();
                request = "UPDATE Book SET TENSACH = @bookname, TENTACGIA = @writername, NGONNGU = @language, QUOCGIA = @country, GIABIA = @price, ANHBIA = @coverImage, SOTRANG = @pagenumber, ISBN = @isbn, MUCLUC = @index, TOMTAT = @summary, NAMXUATBAN = @yearofpublication where MASACH = @idbook";
                command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@bookname", bookname);
                command.Parameters.AddWithValue("@writername", writername);
                command.Parameters.AddWithValue("@language", language);
                command.Parameters.AddWithValue("@country", country);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@coverImage", coverImage);
                command.Parameters.AddWithValue("@pagenumber", pagenumber);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.Parameters.AddWithValue("@index", index);
                command.Parameters.AddWithValue("@summary", summary);
                command.Parameters.AddWithValue("@yearofpublication", yearofpublication);
                command.Parameters.AddWithValue("@idbook", idbook);
                command.ExecuteNonQuery();
                connection.ConnectionClose();
                return "edit successfully";
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        internal string InfoCustomer()
        {
            try
            {
                List<InfoCustomer> list = new List<InfoCustomer>();
                InfoCustomer item;
                connection.ConnectionOpen();
                string request = "SELECT MAKH, TENKH, TIENCONDU, DIEMTICHLUY, NGAYTAO FROM Customer";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    item = new InfoCustomer();
                    item.idCustomer = reader.GetInt32(0);
                    item.nameCustomer = reader.GetString(1);
                    item.money = reader.GetInt32(2);
                    item.getPoints = reader.GetInt32(3);
                    item.datetime = reader.GetDateTime(4);
                    list.Add(item);
                }
                string output = JsonConvert.SerializeObject(list);
                connection.ConnectionClose();
                return output;
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
        internal string InfoDetailCustomer(int id)
        {
            try
            {
                InfoDetailCustomer info = new InfoDetailCustomer();
                info.listPurchaseHistories = new List<ListPurchaseHistory>();
                info.listRechargeHistories = new List<ListRechargeHistory>();
                connection.ConnectionOpen();
                string request = "SELECT TENKH, Email, TIENCONDU, TIENDACHI, SOTIENNAP, DIEMTICHLUY, NGAYTAO from Customer where MAKH = @id";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    info.username = reader.GetString(0);
                    info.email = reader.GetString(1);
                    info.money = reader.GetInt32(2);
                    info.spend = reader.GetInt32(3);
                    info.recharge = reader.GetInt32(4);
                    info.getpoints = reader.GetInt32(5);
                    info.createtime = reader.GetDateTime(6);
                }
                connection.ConnectionClose();
                connection.ConnectionOpen();
                request = "SELECT MAGIAODICH, MENHGIA, TGNAP, LOAITHE, SOSERI, SOTHE FROM RechargeHistory where MAKH = @id";
                command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@id", id);
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    ListRechargeHistory history = new ListRechargeHistory();
                    history.idtrade = reader.GetInt32(0);
                    history.denomination = reader.GetInt32(1);
                    history.timerecharge = reader.GetDateTime(2);
                    history.categoryCard = reader.GetString(3);
                    history.serinumber = reader.GetString(4);
                    history.cardnumber = reader.GetString(5);
                    info.listRechargeHistories.Add(history);
                }
                connection.ConnectionClose();
                connection.ConnectionOpen();
                
                request = "select TENKH FROM Customer where MAKH = @id";
                command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@id", id);
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    usernamee = reader.GetString(0);
                }
                connection.ConnectionClose();
                connection.ConnectionOpen();
                request = "select TENSACH, GIATIEN, TGMUA, CONGDIEM From PurchaseHistory where TENKH = @username";
                command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", usernamee);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListPurchaseHistory history = new ListPurchaseHistory();
                    history.bookname = reader.GetString(0);
                    history.price = reader.GetInt32(1);
                    history.dateBuy = reader.GetDateTime(2);
                    history.pointPlus = reader.GetInt32(3);
                    info.listPurchaseHistories.Add(history);
                }
                connection.ConnectionClose();
                string message = JsonConvert.SerializeObject(info);
                return message;
            }
            catch
            {
                connection.ConnectionClose();
                return "Error from server";
            }
        }
    }
}

