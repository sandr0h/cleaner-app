using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Core.Repositories
{
    public class FileSystemAccessRepository
    {
        public IEnumerable<Entities.File> GetFiles(string folderPath)
        {
            var fileInfo = new DirectoryInfo(folderPath).GetFiles();
            return fileInfo.Select(f => new Entities.File
            {
                Name = f.Name,
                Size = f.Length,
                Path = f.FullName,
                Extension = f.Extension
            }).ToList();
        }

        public void DeleteFile(Entities.File file) => File.Delete(path: file.Path);
    }
}
