using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Dependency
{
    class Program
    {
        public static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IDataProvider>().To<Database>();
            kernel.Bind<IRandomNumberProvider>().To<RandomProvider>();

            var business = kernel.Get<Business>();

            var morningGreet = Greet(new DateTime(2017, 1, 1, 9, 0, 0));
            Console.WriteLine(morningGreet);

            var afternoonGreet = Greet(new DateTime(2017, 1, 1, 15, 0, 0));
            Console.WriteLine(afternoonGreet);

            var nightGreet = Greet(new DateTime(2017, 1, 1, 22, 0, 0));
            Console.WriteLine(nightGreet);

//            var businessObj = new Business();  // Constructor Injection.

            // Another use case:
//            var fileProvider = new FIleDataProvider();
//            var businessObj = new Business(fileProvider, new RandomProvider());


            // Property Injection. It is used when we have an empty constructor.
            // var businessObj = new Business();
            // businessObj.DataProvider = database;

            // There is Parameter Injection too. Used when we have a class with many methods and only one of the methods needs dependency.

            // As a whole Constructor Injection is the most commonly used type of dependency.
            business.VisualizeAllStudents();
        }

        public static string Greet(DateTime date)
        {
            if (date.Hour < 12)
            {
                return "Good morning";
            }
            else if (date.Hour >= 12 && date.Hour < 19)
            {
                return "Good afternoon";
            }
            else
            {
                return "Good night";
            }
        }
    }
}
