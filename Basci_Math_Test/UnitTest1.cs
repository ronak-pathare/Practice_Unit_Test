using NUnit.Framework;
using System;
using Practice_Unit_Test;

namespace Basci_Math_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddition()
        {
            Basic_Math math = new Basic_Math();
            double res = math.Add(10, 10);
            Assert.AreEqual(20,res);
        }

        [Test]
        public void TestSubtraction()
        {
            Basic_Math math = new Basic_Math();
            double res = math.Subtract(10, 10);
            Assert.AreEqual(0, res);
        }

        [Test]
        public void TestMultiplication()
        {
            Basic_Math math = new Basic_Math();
            double res = math.Multiply(10, 10);
            Assert.AreEqual(100, res);
        }

        [Test]
        public void TestDivision()
        {
            Basic_Math math = new Basic_Math();
            double res = math.Divide(10, 10);
            Assert.AreEqual(1, res);
        }
    }
}