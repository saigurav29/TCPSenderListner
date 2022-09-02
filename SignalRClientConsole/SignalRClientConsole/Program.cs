using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace SignalRClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SignalR Client Console!");
            var connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/nmea")
                .Build();
            connection.StartAsync().Wait();
            while (true)
            {
                connection.InvokeCoreAsync("SendMessage", args: new[] { "Gurav", "Hello" });
            }
            connection.On("ReceiveMessage", (string userName, string message) =>
             {
                 Console.WriteLine(userName + ":" + message);
             });
            Console.ReadKey();
        }
    }
}
