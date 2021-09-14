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
            double result = Math.Round(Math.Acos(30 * Math.PI / 180),4);
            double resultMy = Math.Round(Math.PI / 2 - ConsoleApp2.Program.ArcSin(30*Math.PI/180),4);
            Assert.AreEqual(result, resultMy);
        }
    }
}
