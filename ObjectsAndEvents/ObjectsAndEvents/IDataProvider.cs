using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndEvents
{
    public interface IDataProvider
    {
        List<Student> GetStudents();
    }
}
