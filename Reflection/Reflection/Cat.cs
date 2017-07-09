using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public static void MealsEaten(int meals)
        {
            Console.WriteLine("Meals taken: " + meals);
        }
        [Author("Kostadin")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = true)]
        public int Age { get; set; }



    }
}
