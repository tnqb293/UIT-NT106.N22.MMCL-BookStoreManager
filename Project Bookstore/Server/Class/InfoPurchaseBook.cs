using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Class
{
    public class InfoPurchaseBook
    {
        public string bookname { get; set; }
        public string writername {get; set; }
        public string language { get; set; }
        public string country { get; set; }
        public int price { get; set; }
        public byte[] coverImage { get; set; }
        public int numberofbookssold { get; set; }
    }
}
