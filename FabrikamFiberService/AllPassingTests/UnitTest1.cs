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
            stopwatch = Stopwatch.StartNew();
            Thread.Sleep(60000);
            stopwatch.Stop();
        }
        [TestMethod]
        public void Pass2()
        {
            stopwatch = Stopwatch.StartNew();
            Thread.Sleep(40000);
            stopwatch.Stop();
        }
        [TestMethod]
        public void Pass3()
        {
            stopwatch = Stopwatch.StartNew();
            Thread.Sleep(20000);
            stopwatch.Stop();
        }
        [TestMethod]
        public void Pass4()
        {
            stopwatch = Stopwatch.StartNew();
            Thread.Sleep(20000);
            stopwatch.Stop();
        }
    }
}
