using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)]  // Where can the attribute be put.
    public class AuthorAttribute : Attribute
    {
        // Optionals:
        public string Name { get; set; }
        public int Year { get; set; }

        // Mandatory
        public AuthorAttribute(string name)
        {
            this.Name = name;
        }
    }
}
