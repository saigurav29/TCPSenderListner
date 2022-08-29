using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace tcpSender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            tcpsend();
        }

        public static void tcpsend()
        {
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            string HostName = localIPs[3].ToString();
            int port = 1690;
            TcpClient tc = new TcpClient("127.0.0.1", port);
            string filepath = "C:\\Users\\Sai prasad\\source\\repos\\tcpSender\\tcpSender\\tc.txt";
            NetworkStream ns = tc.GetStream();
            FileStream fs = new FileStream(filepath, FileMode.Open);
            int data = fs.ReadByte();
            while (data != -1)
            {
                ns.WriteByte((byte)data);
                Console.WriteLine((byte)data);
                data = fs.ReadByte();
            }
            Console.WriteLine("done");

            fs.Close();
            ns.Close();
            tc.Close();
        }
    }
}
