using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Tests
{
    [TestClass()]
    public class ComplexNumberTests
    {
        [TestMethod()]
        public void ConstructorTest()
        {
            var rnd = new Random();
            for(int i = 0; i<1000; i++)
            {
                var real = rnd.NextDouble() * rnd.Next(100);
                var imaginary = rnd.NextDouble() * rnd.Next(100);
                var num = new ComplexNumber(real, imaginary);
                Assert.AreEqual(real, num.RealPart);
                Assert.AreEqual(imaginary, num.ImaginaryPart);
            }
        }

        [TestMethod()]
        public void ConjugateNumberTest1()
        {
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                var real = rnd.NextDouble() * rnd.Next(100);
                var imaginary = rnd.NextDouble() * rnd.Next(100);
                var num = new ComplexNumber(real, imaginary);
                Assert.AreEqual(real-imaginary, num.ConjugateNumber);
            }
        }
    }
}