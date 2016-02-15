using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("127.0.0.1", 2000);
            server.startServer();
        }
    }
}
