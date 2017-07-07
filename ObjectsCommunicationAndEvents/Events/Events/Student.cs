using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Student
    {
        public string Name { get; set; }

        public void AttendClass(Teacher teacher)
        {
            teacher.StartTalking += TeacherStartTalking;  // Subscribing
        }

        private void TeacherStartTalking(object sender, EventArgs e)
        {
            var teacherName = ((Teacher) sender).Name;

            var args = (TeacherEventsArgs) e;

            Console.WriteLine(this.Name + " is listening " + teacherName + " in " + args.ClassName + " class");
        }
    }
}
