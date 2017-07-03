using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstraction.Animals
{
    class Cat: Animal
    {


        public override string SayHello()
        {
            return base.Description() + "Meow";
        }

        public override string ToString()
        {
            return "Cat";
        }

        public Cat(string name, string color, decimal price, int numbersOfEyes) : base(numbersOfEyes, name, color, price)
        {
        }

        public Cat(string name, string color, int price) : base(name, color, price)
        {
            Name = name;
            Color = color;
            Price = price;
        }
    }
}
