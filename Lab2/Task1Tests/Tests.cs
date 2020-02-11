using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests
{
    [TestClass]
    class Tests
    {
        [TestMethod()]
        public void ConstructorTest()
        {
            var s = new DynamicArray<int>() { 0, 1, 2, 3 };
            for(int i = 0; i < 4; i++)
            {
                Assert.AreEqual(i, s[i]);
            }
        }
    }
}
