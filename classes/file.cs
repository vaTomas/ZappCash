using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZappCash.classes
{
    internal class fileRecord
    {
        public string Path { get; set; }
        public string Directory { get; set; }
        public string FileName { get; set; }
        public string Name { get; set; } 
        public string Extension { get; set; }

        public fileRecord(string path)
        {
            Path = path;
            
            int indexSlash = Path.LastIndexOf(@"\");
            if (indexSlash >= 0)
            {
                Directory = Path.Substring(0, indexSlash); // 'indexSlash' to remove slash
            }
            FileName = $"{indexSlash} {Path.Length}";
            FileName = Path.Substring(indexSlash + 1);

            int indexDot = Path.LastIndexOf(".");
            Extension = Path.Substring(indexDot);

            Name = Path.Substring(indexSlash + 1, indexDot - indexSlash - 1);

        }

        public fileRecord()
        {

        }

    }
}
