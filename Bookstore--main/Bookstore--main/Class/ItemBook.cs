using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore__main.Class
{
    public class ItemBook
    {
        public string BookName { get; set; }
        public string WriterName { get; set; }
        public decimal PriceBook { get; set; }
        public int QuantityBook { get; set; }
        public string NationBook { get; set; }
        public string CategoryBook { get; set; }
        public Image PictureBook { get; set; }
    }
}
