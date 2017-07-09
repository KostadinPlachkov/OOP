using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class AuthorAttribute : Attribute
    {
        public string Name { get; private set; }

        public AuthorAttribute(string name)
        {
            this.Name = name;
        }
    }
}
