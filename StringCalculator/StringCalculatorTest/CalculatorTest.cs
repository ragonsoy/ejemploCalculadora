using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorDominio;

namespace StringCalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAddZeroNumbers()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(0, calculator.Add(""));
        }

        [TestMethod]
        public void TestAddOneNumber()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(4, calculator.Add("4"));
        }

        [TestMethod]
        public void TestAddTwoNumber()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(5, calculator.Add("4,1"));
        }
    }
}
