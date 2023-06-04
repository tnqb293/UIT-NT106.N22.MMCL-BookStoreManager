using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Class
{
    public class InfoDashboardCustomer
    {
        public int AmountPaid { get; set; }
        public int NumberofBooksPurchase { get; set; }
        public int Money { get; set; }
        public int Deposits { get; set; }
        public int Points { get; set; }
        public List<CustomerChart> customerCharts { get; set; }
        public List<BookChart> bookCharts { get; set; }
    }
    public class CustomerChart
    {
        public int top { get; set; }
        public string username { get; set; }
        public int numberofbookpurchase { get; set; }
    }
    public class BookChart
    {
        public int top { get; set; }
        public string bookname { get; set; }
        public int numberofbooksold { get; set; }
    }
}
