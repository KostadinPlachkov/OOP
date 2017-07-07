using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndEvents
{
    public class Business
    {
        // Property Injection
//        public IDataProvider DataProvider { private get; set; }
//
//        public IRandomNumberProvider RandomNumberProvider { private get; set; }

        // Constructor Injection
        private IDataProvider dataProvider;

        private IRandomNumberProvider randomNumberProvider;
        public Business(
            IDataProvider dataProvider,
            IRandomNumberProvider randomNumberProvider)
        {
            this.dataProvider = dataProvider;
            this.randomNumberProvider = randomNumberProvider;
        }

        public void VisualizeAllStudents()
        {
            // Check if you can get all students.

            // var db = new Database();  // Dependency

            var students = this.dataProvider.GetStudents();

            // Draw students.
        }

        public string RandomizeStudentOrder()
        {
            var students = this.dataProvider.GetStudents();

            var random = this.randomNumberProvider.GetRandomNumber();

            // Randomize students.

            return string.Empty;
        }
    }
}
