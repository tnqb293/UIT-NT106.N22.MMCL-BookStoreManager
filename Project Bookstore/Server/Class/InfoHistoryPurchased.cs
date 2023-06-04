using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Class
{
    public class InfoHistoryPurchased
    {
        public int tradingcode { get; set; }
        public byte[] imagecover { get; set; }
        public string bookname { get; set; }
        public int price { get; set; }
        public DateTime datetime { get; set; }
        public int getPoint { get; set; }
    }
}
