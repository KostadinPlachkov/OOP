using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPAndLiskovPrinciple
{
    class Fireman : Worker
    {
        public override void Work()
        {
            Console.WriteLine("Put out fire...");
        }
    }
}
