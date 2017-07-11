using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Data
{
    class FileProvider : IFileProvider
    {
        public string ReadAllText(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public void WriteAllText(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }
    }
}
