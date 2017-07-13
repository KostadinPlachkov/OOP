using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPAndLiskovPrinciple
{
    class Lumberjack: Worker
    {
        public override void Work()
        {
            Console.WriteLine("Falling tree...");
        }
    }
}
