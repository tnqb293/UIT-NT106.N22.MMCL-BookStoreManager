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
        internal string username { get; set; }
        internal string password { get; set; }
        internal string email { get; set; }
        internal string repassword { get; set; }
        internal Thread receiveThread { get; set; }
        internal string passwordEncrypt { get; set; }
    }
}
