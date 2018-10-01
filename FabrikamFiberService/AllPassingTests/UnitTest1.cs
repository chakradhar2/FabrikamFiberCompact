using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Threading;


namespace AllPassingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Pass1()
        {
            System.Threading.Thread.Sleep(60000);
        }
        [TestMethod]
        public void Pass2()
        {
            System.Threading.Thread.Sleep(40000);
        }
        [TestMethod]
        public void Pass3()
        {
            System.Threading.Thread.Sleep(20000);
        }
        [TestMethod]
        public void Pass4()
        {            
            System.Threading.Thread.Sleep(10000);
        }
    }
}
