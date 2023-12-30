using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Core.Const
{
    public static class PathsToClean
    {
        public static class APP_DATA
        {
            public static readonly string USERTEMP = Path.GetTempPath();
            public static readonly string MICROSOFT_EDGE = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"Microsoft\Edge";
        }

        public static class ROOT_C_DSK
        {
            public static readonly string TEMP = @"c:\Windows\Temp";
        }
    }
}
