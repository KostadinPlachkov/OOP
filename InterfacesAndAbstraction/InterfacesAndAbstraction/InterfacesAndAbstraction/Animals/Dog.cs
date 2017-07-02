using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstraction.Animals
{
    class Dog: Animal
    {
        public override string SayHello()
        {
            return base.Description() + "Bark";
        }

        public override string ToString()
        {
            return "Dog";
        }

        public Dog(string name, string color, decimal price, int numbersOfEyes) : base(numbersOfEyes, name, color, price)
        {

        }

        public Dog(string name, string color, int price) : base(name, color, price)
        { 
        }
    }
}
