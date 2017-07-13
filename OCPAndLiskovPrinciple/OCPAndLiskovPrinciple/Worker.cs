using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OCPAndLiskovPrinciple
{
    public abstract class Worker
    {
        public string Name { get; set; }

        public void DailyRoutine()
        {
            GetUp();
            EatBreakfast();
            GoToWork();
            Work();
            Relax();
        }

        public virtual void Relax()
        {
            // ...
        }

        public virtual void Work()
        {
            // ...
        }

        public virtual void GoToWork()
        {
            // ...
        }

        public virtual void EatBreakfast()
        {
            // ...
        }

        public virtual void GetUp()
        {
            // ...
        }
    }
}
