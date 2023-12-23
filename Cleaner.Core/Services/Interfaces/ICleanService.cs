using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Core.Services.Interfaces
{
    public interface ICleanService
    {
        void RunCleaning(string folderPath);
    }
}
