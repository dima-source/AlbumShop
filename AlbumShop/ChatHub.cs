using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumShop
{
    public class ChatHub : Hub
    {
        public async Task Send(string message)
        {
            await Clients.All.SendAsync("Receive", message, Context.User.Identity.Name);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.Others.SendAsync("Notify", $"{Context.User.Identity.Name} вошел в чат");
            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("Notify", $"{Context.User.Identity.Name} покинул в чат");
            await base.OnDisconnectedAsync(exception);
        }
    }
}
