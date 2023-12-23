using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Core.Services.Interfaces
{
    public interface IMessageQueueService
    {
        void AddMessage(string message);
        ConcurrentQueue<string> GetMessages();
    }
}
