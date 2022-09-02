using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace SignalRCore
{
    public class Feed : Hub
    {
        public async Task SendMessage(string userName, string message)
        {
            Console.WriteLine(userName + ":" + message);
            await Clients.All.SendAsync("ReceiveMessage", userName, message);
        }
    }
}
