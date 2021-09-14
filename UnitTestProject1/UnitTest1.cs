using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double result = Math.Round(Math.Cos(60 * Math.PI / 180),4);
            double resultMy = ConsoleApp2.Program.Cos(60 * Math.PI / 180);
            Assert.AreEqual(resultMy, result);
        }
    }
}
