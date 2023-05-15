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
    internal class InfoBook
    {
        internal string bookname { get; set; }
        internal string writername { get; set; }
        internal string category { get; set; }
        internal string country { get; set; }
        internal int price { get; set; }
        internal int numberOfBookRemaining { get; set; }
        internal string coverImage { get; set; }
    }
}
