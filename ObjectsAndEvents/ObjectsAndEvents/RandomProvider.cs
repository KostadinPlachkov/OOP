using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndEvents
{
    public class RandomProvider : IRandomNumberProvider
    {
        private static readonly Random radnom = new Random();
        
        public int GetRandomNumber(int min = 0, int max = Int32.MaxValue)
        {
            return radnom.Next(min, max);
        }
    }
}
