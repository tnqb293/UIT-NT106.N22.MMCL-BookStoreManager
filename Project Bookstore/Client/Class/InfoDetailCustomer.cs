using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Class
{
    public class InfoDetailCustomer
    {
        public string username { get; set; }
        public string email { get; set; }
        public int money { get; set; }
        public int spend { get; set; }
        public int recharge { get; set; }
        public int getpoints { get; set; }
        public DateTime createtime { get; set; }
        public List<ListPurchaseHistory> listPurchaseHistories { get; set; }
        public List<ListRechargeHistory> listRechargeHistories { get; set; }
    }
    public class ListPurchaseHistory
    {
        public string bookname { get; set; }
        public int price { get; set; }
        public DateTime dateBuy { get; set; }
        public int pointPlus { get; set; }   
    }
    public class ListRechargeHistory
    {
        public int idtrade { get; set; }
        public int denomination { get; set; }
        public DateTime timerecharge { get; set; }
        public string categoryCard { get; set; }
        public string serinumber { get; set; }
        public string cardnumber { get; set; }
    }
}
