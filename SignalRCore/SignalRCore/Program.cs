using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;

namespace SignalRCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello starting SignalR app");
            CreateWebHostBuilder(args).Build().Run();
        }

        private static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
           return WebHost.CreateDefaultBuilder(args)
                 .UseStartup<Startup>();
        }

    }
}

//Hello starting SignalR app
//Hosting environment: Production
//Content root path: F:\Project Templates\TCPSenderListner\SignalRCore\SignalRCore\bin\Debug\netcoreapp3.1
//Now listening on: http://localhost:5000
//Now listening on: https://localhost:5001
//Application started. Press Ctrl+C to shut down.

