using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;
namespace UnitTestProject2
{
    [TestClass]
    public class additionTest
    {
        Program p1 = new Program();
        [TestMethod]
        public void testAdditionForPositiveIntegers()
        {
            
            int result =  (int)p1.addition(2,3);
            int expected = 5;
            Assert.AreEqual(result, expected);
            //Assert.Inconclusive("Verify the correctness of addition operation on positive integers");
        }
        [TestMethod]
        public void testAdditionForDoubles()
        {
   
            double result = p1.addition(2.1, 3);
            double expected = 5.1;
            Assert.AreEqual(result, expected);
            //Assert.Inconclusive("Verify the correctness of addition operation on doubles");
        }
        [TestMethod]
        public void testAdditionForNegativeAnyValue()
        {
      
            //double a = Double.Parse("3.2");
            double a = 3.2;
            double b = -2;

            double result = Math.Round(p1.addition(a,b),5);
            double expected = 1.2;
            Console.WriteLine("asd");
            Assert.AreEqual(result, expected);
            //Assert.Inconclusive("Verify the correctness of addition operation on negative values");
        }
        [TestMethod]
        public void testAdditionBuggg()
        {

            double result = p1.addition(2.1, 3);
            double expected = 5.1; //deneme
            Assert.AreEqual(result, expected); // deneme ---------------------------
            //Assert.Inconclusive("Verify the correctness of addition operation on doubles");
        }
    }
}
