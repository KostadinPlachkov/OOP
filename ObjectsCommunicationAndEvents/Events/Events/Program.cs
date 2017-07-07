using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            var student = new Student()
            {
                Name = "Ivan"
            };

            var anotherStudent = new Student()
            {
                Name = "Gosho"
            };

            var thirdStudent = new Student()
            {
                Name = "Pesho"
            };

            var teacher = new Teacher()
            {
                Name = "Mr. Peshov"
            };

            student.AttendClass(teacher);
            anotherStudent.AttendClass(teacher);

            teacher.StartClass("Math");
        }
    }
}
