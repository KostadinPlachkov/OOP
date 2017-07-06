using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndAttributes
{
    [Flags, Author("Kostadin")]
    public enum Permissions
    {
        Read,
        Write,
        Test,
        AnotherTest
    }
}
