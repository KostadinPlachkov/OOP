using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstraction.Animals
{
    class Bunny: Animal
    {
        public override string SayHello()
        {
            return base.Description() + string.Empty;
        }

        public override string ToString()
        {
            return "Bunny";
        }

        public Bunny(string name, string color, decimal price, int numbersOfEyes) : base(numbersOfEyes, name, color, price)
        {

        }

        public Bunny(string name, string color, decimal price) : base(name, color, price)
        {

        }
    }
}
