using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyCustomData<T>: IReadOnlyData<T>
    {
        private List<T> dataList;

        public MyCustomData()
        {
            this.dataList = new List<T>();
        }

        public void Add(T data)
        {
            this.dataList.Add(data);
        }

        public int Count => this.dataList.Count;

        // Indexing
        public T this[int index]
        {
            get
            {
                return this.dataList[index];
            }

        }

        
    }
}
