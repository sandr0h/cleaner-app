using Cleaner.Core.Repositories;
using Cleaner.Core.Repositories.Interfaces;
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
        private readonly IFileSystemAccessRepository _fileSystemAccessRepository;
        private readonly IMessageQueueService _messageQueueService;
        public CleanService() { }
        public CleanService(IFileSystemAccessRepository fileSystemAccessRepository, IMessageQueueService _messageQueueService)
        {
            this._fileSystemAccessRepository = fileSystemAccessRepository;
            this._messageQueueService = _messageQueueService;
        }
        public void RunCleaning(string folderPath)
        {
            var exceptions = new ConcurrentQueue<Exception>();
            var files = this._fileSystemAccessRepository.GetFiles(folderPath: folderPath);

            Parallel.ForEach(files, file => 
            {
                try
                {
                    this._fileSystemAccessRepository.DeleteFile(file);
                    this._messageQueueService.AddMessage($"The {file.Path} file has been successfully deleted!!");
                }
                catch (Exception e)
                {
                    this._messageQueueService.AddMessage(e.Message);
                }
            });
        }
    }
}
