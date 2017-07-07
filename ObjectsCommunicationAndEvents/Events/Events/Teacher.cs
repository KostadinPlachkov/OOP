using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Teacher
    {
        public event EventHandler StartTalking;

        public string Name { get; set; }

        public void StartClass(string className)
        {
            this.StartTalking(this, new TeacherEventsArgs
            {
                ClassName = className
            });
        }
    }
}
