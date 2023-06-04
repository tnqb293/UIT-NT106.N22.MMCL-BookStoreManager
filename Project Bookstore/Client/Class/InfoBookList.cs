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
        public string language { get; set; }
        public string country { get; set; }
        public int price { get; set; }
        public int pagenumber { get; set; }
        public byte[] coverImage { get; set; }
        public string isbn { get; set; }
        public string index { get; set; }
        public string summary { get; set; }
        public int numberofbookssold { get; set; }
        public int yearofpublication { get; set; }
    }
}
