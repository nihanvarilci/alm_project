using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;
//using ConsoleApplication2.controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          //  HomeController homeController = new HomeController();
            Assert.AreNotEqual(1,1);
            //dfsd
            Assert.AreSame(2,3);
        }
    }
}
