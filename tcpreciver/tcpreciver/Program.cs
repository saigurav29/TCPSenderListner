using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace tcpreciver
{
    class Program
    {
        public delegate void testDelegate(string str);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread t = new Thread(new ThreadStart(ListenData));
            t.Start();
        }

        public static void ListenData()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int prt = 1690;
            TcpListener tl = new TcpListener(ip, prt);
            tl.Start();
            TcpClient tc = tl.AcceptTcpClient();
            NetworkStream ns = tc.GetStream();
            StreamReader sr = new StreamReader(ns);
            string result = sr.ReadToEnd();

            //Invoke(new testDelegate(print), new object[] { result });
            Console.WriteLine(result);

            tc.Close();
            tl.Stop();
        }

        private static void print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
