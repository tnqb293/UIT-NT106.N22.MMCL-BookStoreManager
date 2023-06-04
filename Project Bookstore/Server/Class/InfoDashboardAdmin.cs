using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Class
{
    public class InfoDashboardAdmin
    {
        public int Revenue { get; set; }
        public int Booksold { get; set; }
        public int CustomerNumber { get; set; }
        public int NumberOfBookCustomer { get; set; }
        public List<CustomerChartAdmin> customerCharts { get; set; }
        public List<BookChartAdmin> bookCharts { get; set; }
    }
    public class CustomerChartAdmin
    {
        public int top { get; set; }
        public string username { get; set; }
        public int numberofbookpurchase { get; set; }
    }
    public class BookChartAdmin
    {
        public int top { get; set; }
        public string bookname { get; set; }
        public int numberofbooksold { get; set; }
    }
}
