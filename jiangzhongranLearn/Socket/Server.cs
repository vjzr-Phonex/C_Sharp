using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SocketServer
{
    class Server
    {
        private string hostIp;
        private int port;
        private IPAddress ip;
        private IPEndPoint ipe;
        private Socket socketServer;
        private Socket socketClient;
        private SocketHandler handler;

        public Server(string hostIp, int port)
        {
            this.init(hostIp, port);
        }

        private void init(string hostIp, int port)
        {
            Console.WriteLine("服务器启动初始化");
            this.hostIp = hostIp;
            this.port = port;
            this.ip = IPAddress.Parse(hostIp);
            this.ipe = new IPEndPoint(ip, port);
            this.socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.socketServer.Bind(ipe);
            Console.WriteLine("Start Binding!");
        }

        public void startServer()
        {
            this.socketServer.Listen(0);
            Console.WriteLine("Start Server!");
            Socket client = socketServer.Accept();
            Console.WriteLine("Connect Success!");
        }

        public void StopServer()
        {
            socketClient.Close();
            socketServer.Close();
            Console.WriteLine("Server Stopped!");
        }

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public string HostIp
        {
            get { return hostIp; }
            set { hostIp = value; }
        }

        public System.Net.IPAddress Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        public System.Net.IPEndPoint Ipe
        {
            get { return ipe; }
            set { ipe = value; }
        }

        public System.Net.Sockets.Socket SocketServer
        {
            get { return socketServer; }
            set { socketServer = value; }
        }

        public System.Net.Sockets.Socket SocketClient
        {
            get { return socketClient; }
            set { socketClient = value; }
        }

        public SocketServer.SocketHandler Handler
        {
            get { return handler; }
            set { handler = value; }
        }
    }
}
