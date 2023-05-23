using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client.Class
{
    internal class InfoBook
    {
        public string bookname { get; set; }
        public string writername { get; set; }
        public string category { get; set; }
        public string country { get; set; }
        public int price { get; set; }
        public int numberOfBookRemaining { get; set; }
        public byte[] coverImage { get; set; }
    }
}
