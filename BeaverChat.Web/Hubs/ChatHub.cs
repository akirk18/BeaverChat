using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BeaverChat.Backend.Hubs
{
    public class ChatHub : Hub
    {
        public async Task AddToGroup(string groupName, string user)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("Entered", user);
        }

        public async Task RemoveFromGroup(string groupName, string user)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("Left", user);
        }

        public async Task SendMessage(string groupName, string user, string message)
        {
            await Clients.Group(groupName).SendAsync("RecieveMessage", user, message);
        }
    }
}
