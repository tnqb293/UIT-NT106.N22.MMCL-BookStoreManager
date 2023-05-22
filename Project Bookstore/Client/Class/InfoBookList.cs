using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Class
{
    public class InfoBookList
    {
        public string bookname { get; set; }
        public string writername { get; set; }
        public string category { get; set; }
        public string country { get; set; }
        public int price { get; set; }
        public int numberOfBookRemaining { get; set; }
        public string coverImage { get; set; }
    }
}
