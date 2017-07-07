using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    public interface IRandomNumberProvider
    {
        int GetRandomNumber(int min = 0, int max = int.MaxValue);
    }
}
