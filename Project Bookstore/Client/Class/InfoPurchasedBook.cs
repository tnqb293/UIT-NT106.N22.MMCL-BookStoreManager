using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Class
{
    public class InfoPurchasedBook
    {
        public string bookname { get; set; }
        public string writername { get; set; }
        public string language { get; set; }
        public string country { get; set; }
        public int price { get; set; }
        public byte[] coverImage { get; set; }
        public int numberofbookssold { get; set; }
    }
}
