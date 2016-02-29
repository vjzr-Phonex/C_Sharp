using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace SocketServer
{
    class SocketHandler
    {
        private byte[] recieveBuffer = new byte[1024];
        private byte[] sendBuffer ;
        private string recieveString = "";
        private string sendString = "Now Send Message To Client: Hello!";
        private int bytes;
        private Server server;

        public SocketHandler(Server server) 
        {
            this.server = server;    
        }

        public string MessageRecieve()
        {
            Socket client = server.SocketClient;
            bytes = client.Receive(recieveBuffer, recieveBuffer.Length,0);
            recieveString += Encoding.ASCII.GetString(recieveBuffer, 0, bytes);
            Console.WriteLine("Recieve Message From Client: " + recieveString);
            return recieveString;
        }

        public void sendMessage()
        {
            sendBuffer = Encoding.ASCII.GetBytes(sendString);
            server.SocketClient.Send(sendBuffer,sendBuffer.Length,0);
            Console.WriteLine("Message Sent!");
        }

    }
}
