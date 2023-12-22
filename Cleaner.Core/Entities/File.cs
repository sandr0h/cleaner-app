﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Core.Entities
{
    public class File
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public string Extension { get; set; }
    }
}
