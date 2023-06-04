using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ConnectionManager
    {
        public static IPAddress LocalIPAddress { get { return Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork); } }
        public static int Port { get { return 42000; } }
        public static IPEndPoint EndPoint { get { return new IPEndPoint(LocalIPAddress, Port); } }
        public static Socket CreateListener()
        {
            Socket socket = null;
            try
            {
                // Create a TCP/IP socket.
                socket = CreateSocket();
                socket.Bind(EndPoint);
                socket.Listen(10);
            }
            catch (Exception)
            {
                throw;
            }

            return socket;
        }
        public static Socket CreateSocket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
    }
}
