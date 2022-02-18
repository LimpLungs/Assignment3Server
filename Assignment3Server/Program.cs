using System;
using System.Net;
using System.Net.Sockets;

namespace Assignment3Server
{

    class Program
    {
        private const String IP_STRING = "127.0.0.1";

        static void Main(string[] args)
        {
            StartServer();
        }

        private static void StartServer()
        {
            Console.WriteLine("Starting server...");

            var IP_ADDRESS = IPAddress.Parse(IP_STRING); // since we are running locally, can use the same one
            var IP_ENDPOINT = new IPEndPoint(IP_ADDRESS, 7777); // since we are running locally, can use the same one

            var SERVER_SOCKET = new Socket(IP_ADDRESS.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                SERVER_SOCKET.Bind(IP_ENDPOINT);
                SERVER_SOCKET.Listen();
                Console.WriteLine("Bound and listening...");
            }
            catch (SocketException e) { Console.WriteLine(e); };

            if (IP_ADDRESS != null && IP_ENDPOINT != null)
            while (SERVER_SOCKET != null)
            {
            }
        }
    }
}
