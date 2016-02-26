using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SocketClient
{
    class Client
    {
        private string host;
        private int port;
        private Socket socketClient;
        private IPAddress ip;
        private IPEndPoint ipe;
        private string sendString = "Hello,this is Client.";
        private byte[] sendBuffer ;


        public Client(string host,int port)
        {
            this.init(host,port);
        }

        public void init(string host, int port) 
        {
            this.host = host;
            this.port = port;
            ip = IPAddress.Parse(host);
            ipe = new IPEndPoint(ip,port);

            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        public void Start()
        {
            socketClient.Connect(ipe);
        }

        public void SendMessage()
        {
            sendBuffer = Encoding.ASCII.GetBytes(sendString);
            socketClient.Send(sendBuffer);
        }

        public void RecieveMessage()
        {
            string recieveMessage = "";
            byte[] recieveBuffer = new byte[1024];
            int bytes;
            bytes = socketClient.Receive(recieveBuffer,recieveBuffer.Length,0);
            recieveMessage += Encoding.ASCII.GetString(recieveBuffer, 0, bytes);
            Console.WriteLine("Client Recieve Message: "+recieveMessage);
        }

        public void Close()
        {
            this.socketClient.Close();
            Console.WriteLine("Client Closed!");
        }
    }
}
