using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleAppTDD.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionTest()
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Addition(2, 3), 5);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Multiplication(2, 3), 6);
        }

        [TestMethod]
        public void DivisionTest()
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Division(6, 3), 2);
            Assert.AreEqual(calculator.Division(3, 0), -9999);
            //Assert.ThrowsException<DivideByZeroException>(() => calculator.Division(3, 0));
        }

        [TestMethod]
        public void HashTest()
        {
            var computeHash = new ComputeHash();
            Assert.AreEqual(computeHash.Hash("VSR"), 124);
            Assert.AreEqual(computeHash.Hash(""), -1);
        }
    }
}
