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

        [TestMethod]
        public void TestAddThreeOrMoreNumber()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(10, calculator.Add("1,1,3,5"));
        }

        [ExpectedException(typeof(NotANumberException))]
        [TestMethod]
        public void TestAddingStuffThatIsNotANumber()
        {
            Calculator calculator = new Calculator();
            calculator.Add("jhfvbsu");
        }
    }
}
