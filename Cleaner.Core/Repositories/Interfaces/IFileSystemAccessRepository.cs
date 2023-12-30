using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Core.Repositories.Interfaces
{
    public interface IFileSystemAccessRepository
    {
        IEnumerable<Entities.File> GetFiles(string folderPath);
        void DeleteFile(Entities.File file);
    }
}
