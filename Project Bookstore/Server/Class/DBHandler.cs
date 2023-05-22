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

namespace Server.Class
{
    public class DBHandler
    {
        DbConnection connection = new DbConnection();
        internal string RegisterDB(string username,string password, string email)
        {
            try
            {
                connection.ConnectionOpen();
                //Kiểm tra username đăng ký trong db đã có username tồn tại chưa
                string request = "SELECT COUNT(*) From Customer WHERE Username = @username";
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
                    request = "INSERT INTO Customer (Username, Password, Email) VALUES (@username, @password, @email)";
                    command = new SqlCommand(request, connection.sqlConnection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.ExecuteNonQuery();
                    connection.ConnectionClose();
                    return "register success";
                }
            }
            catch
            {
                return "Error from server";
            }
        }
        
        internal string LoginDB(string username, string password)
        {
            try
            {
                connection.ConnectionOpen();
                string request = "select count(*) from Customer where Username = @username and Password = @password";
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

        
        internal string AddBookAdminDB(string bookname, string writername, string category, string country, int price, int numberOfBookRemaining, string coverImage)
        {
            try
            {
                connection.ConnectionOpen();
                string request = "INSERT INTO Book (Bookname, Writername, Category, Country, Price, NumberOfBookRemaining, CoverImage)" +
                    "VALUES (@bookname, @writername, @category, @country, @price, @numberOfBookRemaining, @coverImage)";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@bookname", bookname);
                command.Parameters.AddWithValue("@writername", writername);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@country", country);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@numberOfBookRemaining", numberOfBookRemaining);
                command.Parameters.AddWithValue("@coverImage", coverImage);
                command.ExecuteNonQuery();
                connection.ConnectionClose();
                return "add book success";
            }
            catch
            {
                return "Error from server";
            }
        }
        internal string InforDashboardCustomerDB(string username)
        {
            try
            {
                connection.ConnectionOpen();
                string request = "select Money, AmountPaid, NumberOfBookPurchase from Customer where Username = @username";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                //int count = (int)command.ExecuteScalar();
                //command.ExecuteScalar();
                SqlDataReader reader = command.ExecuteReader();
                InfoDashboardCustomer info = new InfoDashboardCustomer();
                while (reader.Read())
                {
                    info.Money = reader.GetInt32(0);
                    info.AmountPaid = reader.GetInt32(1);
                    info.NumberofBooksPurchase = reader.GetInt32(2);
                }
                string inforDashboardCustomer = info.Money.ToString() + " " + info.AmountPaid.ToString() + " " + info.NumberofBooksPurchase.ToString();
                connection.ConnectionClose();
                return inforDashboardCustomer;

            }
            catch
            {
                return "Error from server";
            }
        }
        //internal List<InfoBook> LoadItemBook()
        //{
        //    connection.ConnectionOpen();
        //    string request = "select * from Book";
        //    SqlCommand command = new SqlCommand(request, connection.sqlConnection);
        //    SqlDataReader reader = command.ExecuteReader();
        //    List<InfoBook> ListInfoBook = new List<InfoBook>();
        //    while (reader.Read())
        //    {
        //        InfoBook infoBook = new InfoBook();
        //        infoBook.bookname = reader.GetString(0);
        //        infoBook.writername = reader.GetString(1);
        //        infoBook.category = reader.GetString(2);
        //        infoBook.country = reader.GetString(3);
        //        infoBook.price = reader.GetInt32(4);
        //        infoBook.numberOfBookRemaining = reader.GetInt32(5);
        //        infoBook.coverImage = reader.GetString(6);
        //        ListInfoBook.Add(infoBook);
        //    }
        //    reader.Close();
        //    connection.ConnectionClose();
        //    return ListInfoBook;
        //}

        internal string LoadItemBook()
        {
            try
            {
                List<InfoBook> infoBooks = new List<InfoBook>();
                connection.ConnectionOpen();
                string request = "select Bookname, Writername, Category, Country, Price, NumberOfBookRemaining, CoverImage from Book";
                SqlCommand command = new SqlCommand(request, connection.sqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InfoBook infoBook = new InfoBook();
                        infoBook.bookname = reader.GetString(0);
                        infoBook.writername = reader.GetString(1);
                        infoBook.category = reader.GetString(2);
                        infoBook.country = reader.GetString(3);
                        infoBook.price = reader.GetInt32(4);
                        infoBook.numberOfBookRemaining = reader.GetInt32(5);
                        infoBook.coverImage = reader.GetString(6);
                        infoBooks.Add(infoBook);
                    }
                    string jsonObject = JsonConvert.SerializeObject(infoBooks);
                    connection.ConnectionClose();
                    return jsonObject;
                }

            }
            catch
            {
                return "Error from server";
            }
        }
    }
}
