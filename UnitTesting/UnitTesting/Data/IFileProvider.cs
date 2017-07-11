using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Data
{
    public interface IFileProvider
    {
        string ReadAllText(string filePath);
        void WriteAllText(string filePath, string content);
    }
}
