using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace SocketClient
{
    class Client
    {
        private string host;
        private int port;

        public Client(string host,int port)
        {
            this.init(host,port);
        }

        public void init(string host, int port) 
        {
            this.host = host;
            this.port = port;
            IPAddress ip = IPAddress.Parse(host);
            IPEndPoint ipe = new IPEndPoint(ip,port);

        }
    }
}
