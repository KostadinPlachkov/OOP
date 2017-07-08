using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        public static void Main(string[] args)
        {
            var obj = new object();

            var objType = obj.GetType();

            var programType = typeof(Program);

            var catType = typeof(Cat);

            Console.WriteLine("Name: " + GetTypeName<Cat>());
            Console.WriteLine("Full name: " + catType.FullName);  // .FullName = namespace.name
            // Console.WriteLine("Assembly full name: " + catType.Assembly.FullName);

            // Properties
            Console.WriteLine("Properties of " + catType.Name + ":");
            foreach (var property in catType.GetProperties())
            {
                Console.WriteLine("- " + property.PropertyType.Name + " " + property.Name);
            }

            var animalType = catType.BaseType;
            Console.WriteLine(animalType.Name + " is a base class of " + catType.Name);

            // Interfaces
            var allInterfaces = animalType.GetInterfaces();
            Console.WriteLine("Interfaces of " + catType.Name + ":");
            foreach (var interf in allInterfaces)
            {
                Console.WriteLine("- " + interf.Name);
            }

            // Assembly
            var typesInCurrentAssembly = Assembly.GetEntryAssembly() // Reflection
                .GetTypes()
                .Where(t => t.IsAbstract && !t.IsInterface);  // Abstract classes only
            Console.WriteLine("Abstract classes in assembly:");
            foreach (var type in typesInCurrentAssembly)
            {
                Console.WriteLine("- " + type.Name);
            }

//            var list = new List<Cat>();
//            var watch = Stopwatch.StartNew();
//            for (int i = 0; i < 100000; i++)
//            {
//                var cat = Activator.CreateInstance<Cat>();
//                list.Add(cat);
//            }

            var list = new List<Cat>();
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var cat = New<Cat>.Instance();
                list.Add(cat);
            }

            watch.Stop();
            Console.WriteLine("Time with Expression: " + watch.Elapsed);
            Console.WriteLine("List count: " + list.Count);  // Minimizing the C# optimization, for the accuracy.

            list = new List<Cat>();
            watch = Stopwatch.StartNew();
            for (int i = 0; i < 100000; i++)
            {
                var cat = new Cat();
                list.Add(cat);
            }
            watch.Stop();
            Console.WriteLine("Time with new: " + watch.Elapsed);
            Console.WriteLine("List count: " + list.Count);
        }

        private static string GetTypeName<T>()
        {
            return typeof(T).Name;
        }


        // Slower than Activator.
        public static T CreateInstance<T>()
            where T : class , new()
        {
            return new T();
        }

        // Faster than new. For empty constructors.
        public class New<T>
            where T : class, new()
        {
            public static Func<T> Instance = Expression.Lambda<Func<T>>(Expression.New(typeof(T))).Compile();
        }
    }
}
