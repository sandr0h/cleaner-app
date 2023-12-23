using Cleaner.Core.Services.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Core.Services
{
    public class MessageQueueService : IMessageQueueService
    {
        public ConcurrentQueue<string> Queue { get; private set; }
        public MessageQueueService() => this.Queue = new ConcurrentQueue<string>();
        public void AddMessage(string message) => this.Queue.Enqueue(message);
        public ConcurrentQueue<string> GetMessages() => this.Queue;
    }
}
