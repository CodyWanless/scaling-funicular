using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChat
{
    internal sealed class ChatHub : Hub
    {
        public Task SendMessage(string user, string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}