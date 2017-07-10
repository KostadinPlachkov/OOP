using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Test
{
    [TestClass]
    public class HighScoreTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        [Timeout(1000)]
        public void SomeTest()
        {
            Thread.Sleep(500);
            throw new System.Exception();
        }
    }
}
