using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRChat.Models
{
    public class ChatHistory
    {
        public int ChatHistoryId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
