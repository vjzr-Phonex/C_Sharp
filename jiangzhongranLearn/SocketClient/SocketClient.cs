using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocketClient
{
    class SocketClient
    {
        private int port;
        private string ip;

        public SocketClient(int port, string ip)
        {
        }

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }
    }
}
