using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using SignalRChat.Models;
using System.Data.Entity;

namespace SignalRChat.Services
{
    public class ChatHub : Hub
    {
       
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
            var chatHistory = new ChatHistory()
            {
                CreateTime = DateTime.Now,
                Message = message,
                Name = name
            };

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.ChatHistories.Add(chatHistory);
                db.SaveChanges();
            }
        }
    }
}
