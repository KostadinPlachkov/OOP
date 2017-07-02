using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesAndAbstraction.Animals;

namespace InterfacesAndAbstraction
{
    class Startup
    {
        static void Main()
        {
            var listOfAnimals = new List<Animal>();

            listOfAnimals.Add(new Bunny(name: "Gosho", color: "Black", price: 20));
            listOfAnimals.Add(new Cat(name: "Maria", color: "Brown", price: 5, numbersOfEyes: 1));
            listOfAnimals.Add(new Dog(name: "Ivan", color: "White", price: 500));

            foreach (var animal in listOfAnimals)
            {
                Console.WriteLine($"{animal.Description()}:\n- name: {animal.Name}\n- color: {animal.Color}\n- number of eyes: {animal.NumbersOfEyes}\n- price {animal.Price}");
            }
        }
    }
}
