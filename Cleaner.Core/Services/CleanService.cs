using Cleaner.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Core.Services
{
    public class CleanService
    {
        private FileSystemAccessRepository _fileSystemAccessRepository = new FileSystemAccessRepository();
        public void RunCleaning(string folderPath)
        {
            var files = this._fileSystemAccessRepository.GetFiles(folderPath: folderPath);

            Parallel.ForEach(files, file => 
            {
                this._fileSystemAccessRepository.DeleteFile(file);
            });
        }
    }
}
