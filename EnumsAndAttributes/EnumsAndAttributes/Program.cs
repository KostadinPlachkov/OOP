using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndAttributes
{
    [Author("Kostadin", Year = 2017)]
    class Program
    {
        static void Main(string[] args)
        {
            // Enums
            var color = Colors.Blue;

            if (color != Colors.Blue)
            {
                color = Colors.Red;
            }

            Console.WriteLine(color);

            var task = new Task();
            task.State = TaskState.Pending;

            var arrayOfColors = Enum.GetValues(typeof(Colors));
            foreach (var col in arrayOfColors)
            {
                Console.WriteLine(col);
            }

            var black = Enum.Parse(typeof(Colors), "Black");

            Console.WriteLine(black);

            // Attributes
            var value = Permissions.Read | Permissions.Write;

            Console.WriteLine(value);

            if (value.HasFlag(Permissions.Read))
            {
                Console.WriteLine("Permission has Read");
            }

            var types = Assembly.GetEntryAssembly() //Assembly of the main method
                .GetTypes() // Array
                .Where(t => t.GetCustomAttributes<AuthorAttribute>().Any());

            Console.WriteLine("All types with author in the project:");
            foreach (var type in types)
            {
                var typeName = type.Name;
                var attributes = type.GetCustomAttributes<AuthorAttribute>()
                    .Select(a => a.Name);
                var authors = string.Join(", ", attributes);
                Console.WriteLine("- " + typeName + ": " + authors);
            }

        }
    }
}
