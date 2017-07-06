using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndAttributes
{
    [Author("Ivan")]
    [Author("Maya")]
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public TaskState State { get; set; }
    }
}
