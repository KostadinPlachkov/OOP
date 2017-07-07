using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    public class Database : IDataProvider
    {
        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student(),
                new Student(),
                new Student(),
                new Student()
            };
        }
    }
}
