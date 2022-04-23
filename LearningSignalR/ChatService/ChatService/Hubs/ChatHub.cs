using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using ChatService.Models;

namespace ChatService.Hubs
{
    public class ChatHub : Hub
    {
        private readonly string _botUser;
        public ChatHub()
        {
            _botUser = "MyChat Bot";
        }
        public async Task JoinRoom(UserConnection userConnection)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.Room);


            await Clients.Group(userConnection.Room).SendAsync("RecieveMessage",
                                        _botUser, 
                                        $"{userConnection.User} se unio a la sala {userConnection.Room}");
        }
    }
}
