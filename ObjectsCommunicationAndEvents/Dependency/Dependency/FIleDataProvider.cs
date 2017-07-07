using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class FIleDataProvider : IDataProvider
    {
        public List<Student> GetStudents()
        {
            var allStudents = File.ReadAllText("students.txt");

            // Parse the students data

            return new List<Student>();
        }
    }
}
