using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPAndLiskovPrinciple
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            workers.Add(new Lumberjack());
            workers.Add(new Fireman());
            foreach (var worker in workers)
            {
                worker.DailyRoutine();
            }
        }
    }
}
