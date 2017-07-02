using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstraction.Animals
{
    public abstract class Animal
    {

        public string Name { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public readonly int NumbersOfEyes = 2;

        protected Animal(int numbersOfEyes, string name, string color, decimal price)
        {
            Name = name;
            Color = color;
            Price = price;
            NumbersOfEyes = numbersOfEyes;
        }

        protected Animal(string name, string color, decimal price)
        {
            Name = name;
            Color = color;
            Price = price;
        }


        public virtual string Description()
        {
            return "Im animal";
        }

        public abstract string SayHello();
    }
}
