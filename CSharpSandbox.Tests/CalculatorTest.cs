using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpSandbox.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAdd()
        {
            var target = new Calculator();
            Assert.AreEqual(4, target.Add(2,2));
        }
    }
}