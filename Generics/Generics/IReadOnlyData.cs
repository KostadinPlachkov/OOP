using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // Generic Interface
    interface IReadOnlyData<T>
    {
        void Add(T item);

        int Count { get;}

        T this[int index] { get; }
    }
}
