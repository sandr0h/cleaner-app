using Cleaner.Core.Repositories;
using Cleaner.Core.Services.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Core.Services
{
    public class CleanService : ICleanService
    {
        private readonly IMessageQueueService _messageQueueService;
        private FileSystemAccessRepository _fileSystemAccessRepository = new FileSystemAccessRepository();
        public CleanService() { }
        public CleanService(IMessageQueueService _messageQueueService) => this._messageQueueService = _messageQueueService;
        public void RunCleaning(string folderPath)
        {
            var exceptions = new ConcurrentQueue<Exception>();
            var files = this._fileSystemAccessRepository.GetFiles(folderPath: folderPath);

            Parallel.ForEach(files, file => 
            {
                try
                {
                    this._fileSystemAccessRepository.DeleteFile(file);
                    this._messageQueueService.AddMessage($"File {file.Path} deleted!");
                }
                catch (Exception e)
                {
                    this._messageQueueService.AddMessage(e.Message);
                }
            });
        }
    }
}
