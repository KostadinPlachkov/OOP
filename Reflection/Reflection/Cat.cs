using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Cat : Animal
    {
        // static Cat() { }  // It executes only once.
        public Cat()
        {
            this.Name = "John";
        }

        public Cat(string name)
        {
            Name = name;
        }

        public Cat(string name, int age)
            : this(name)
        {
            Age = age;
        }

        public static string SomeStaticField;
        public string Name { get; set; }
        public int Age { get; set; }



    }
}
