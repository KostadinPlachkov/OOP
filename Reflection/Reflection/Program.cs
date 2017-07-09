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

            // Fields
            var catFields = new Cat();
            var fields = catType.GetFields(
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            Console.WriteLine("All public, private and static fields in " + catType.Name + ":");
            foreach (var fieldInfo in fields)
            {
                Console.WriteLine("- " + fieldInfo.Name);
                // Field Altering
                if (fieldInfo.Name.Contains("Name"))
                {
                    fieldInfo.SetValue(catFields, "John");
                }

            }
            Console.WriteLine("Name: " + catFields.Name);
            Console.WriteLine("Static field with name 'SomeStaticField': " + catType.GetField("SomeStaticField", BindingFlags.Static | BindingFlags.Public));

            // Properties
            var anotherCat = new Cat()
            {
                Name = "Annie",
                Age = 25

            };
            var anotherCatType = anotherCat.GetType();
            var nameProperty = anotherCatType.GetProperty("Name");
            Console.WriteLine("Name of the cat: " + nameProperty.GetValue(anotherCat));
            nameProperty.SetValue(anotherCat, "Bob");
            Console.WriteLine("New name of the cat: " + nameProperty.GetValue(anotherCat));

            // GetTypeInfo() is relevant in some cases.

            // Constructors
            var constructors = typeof(Cat).GetConstructors();
            Console.WriteLine("Constructors parameters:");
            foreach (var constructor in constructors)
            {
                var paramaters = constructor.GetParameters();
                foreach (var param in paramaters)
                {
                    Console.WriteLine(param.ParameterType.Name + " " + param.Name);
                }
                Console.WriteLine("-----------------");
            }

            var constructorStringInt = typeof(Cat).GetConstructor(new[] {typeof(string), typeof(int)});
            Console.WriteLine("Constructor of string and int: " + constructorStringInt);
            var catCon = constructorStringInt.Invoke(new object[]{ "Emma", 20});
            Console.WriteLine(catCon);

            // Methods
            var methods = typeof(Cat).GetMethods();
            Console.WriteLine("All methods of Cat: ");
            foreach (var meth in methods)
            {
                Console.WriteLine("- " + meth.Name);
            }
            var method = catType.GetMethod("MealsEaten");
            method.Invoke(null, new object[] {3});

            // Obtaining Attributes
            var authorOfCateName = typeof(Cat)
                .GetProperty("Name")
                .GetCustomAttribute<AuthorAttribute>()
                ?.Name;
            Console.WriteLine("Author of Cat Name property: " + authorOfCateName);
            Console.WriteLine("All attributes in class Cat: ");
            // How NOT to write code!!!!
            typeof(Cat)
                .GetProperties()
                .Select(pr => new
                {
                    Name = pr.Name,
                    Attrs = pr.GetCustomAttributes()
                })
                .ToList()
                .ForEach(pr => Console.WriteLine(
                    "- " + 
                    pr.Name + ": " +
                    string.Join(
                        ", ", pr.Attrs.Select(
                            a => a.GetType()
                            .Name
                            .Replace("Attribute", string.Empty)))));

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
