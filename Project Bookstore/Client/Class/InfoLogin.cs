using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client.Class
{
    public class InfoLogin
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string repassword { get; set; }
        public Thread receiveThread { get; set; }
        public string passwordEncrypt { get; set; }
    }
}
