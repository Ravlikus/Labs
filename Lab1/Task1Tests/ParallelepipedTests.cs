using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests
{
    [TestClass()]
    public class ParallelepipedTests
    {
        [TestMethod()]
        public void ConstructorTests()
        {
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                var a = rnd.NextDouble() * rnd.Next(1000);
                var b = rnd.NextDouble() * rnd.Next(1000);
                var c = rnd.NextDouble() * rnd.Next(1000);
                var figure = new Parallelepiped(a, b, c);
                Assert.AreEqual(a, figure.A);
                Assert.AreEqual(b, figure.B);
                Assert.AreEqual(c, figure.C);
            }
        }

        [TestMethod()]
        public void VTest()
        {
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                var a = rnd.NextDouble() * rnd.Next(1000);
                var b = rnd.NextDouble() * rnd.Next(1000);
                var c = rnd.NextDouble() * rnd.Next(1000);
                var figure = new Parallelepiped(a, b, c);
                Assert.AreEqual(a * b * c, figure.V);
            }
        }


        [TestMethod()]
        public void STest()
        {
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                var a = rnd.NextDouble() * rnd.Next(1000);
                var b = rnd.NextDouble() * rnd.Next(1000);
                var c = rnd.NextDouble() * rnd.Next(1000);
                var figure = new Parallelepiped(a, b, c);
                Assert.AreEqual(2 * a * b + 2 * a * c + 2 * b * c, figure.S);
            }
        }
    }
}