using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;
namespace UnitTestProject2
{
    [TestClass]
    public class divisionTest
    {
        Program p1 = new Program();
        [TestMethod]
        public void divisionTestForIntegers()
        {
            int result = (int)p1.division(8, 4);
            int expected = 2;
            Assert.AreEqual(result, expected);
            //Assert.Inconclusive("Verify the correctness of addition operation on positive integers");
        }

        [TestMethod]
        public void divisionTestForDoubles()
        {
            double result = p1.division(2,4);
            double expected = 0.5;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void divisionTestForDividingByZero()
        {
            double result = p1.division(3, 0);
            Assert.IsNotNull(result);
        }
    }
}
