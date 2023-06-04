using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Class
{
    public class InfoBook
    {
        public string bookname { get; set; }
        public string writername { get; set; }
        public string language { get; set; }
        public string country { get; set; }
        public int price { get; set; }
<<<<<<< HEAD
        public int pagenumber { get; set; }
        public byte[] coverImage { get; set; }
        public string isbn { get; set; }
        public string index { get; set; }
        public string summary { get; set; }
        public int numberofbookssold { get; set; }
        public int yearofpublication { get; set; }
        public byte[] contentbook { get; set; }
=======
        public int numberOfBookRemaining { get; set; }
        public byte[] coverImage { get; set; }
>>>>>>> 1f2fface7cc32121abf3fc0f11ccd2bf8df68dc0
    }
}
