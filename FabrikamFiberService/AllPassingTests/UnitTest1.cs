using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

Overloads

namespace AllPassingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Pass1()
        {
            Sleep(60000);
        }
        [TestMethod]
        public void Pass2()
        {
            Sleep(40000);
        }
        [TestMethod]
        public void Pass3()
        {
            Sleep(20000);
        }
        [TestMethod]
        public void Pass4()
        {
            Sleep(20000);
        }
    }
}
