using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    [TestClass()]
    public class HelpersTests
    {
        [TestMethod()]
        public void FibTest_0()
        {
            Assert.AreEqual(0, Helpers.fib(0));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),"A userId of null was inappropriately allowed.")]
        public void FibTest_Negative()
        {
            Assert.AreEqual(0, Helpers.fib(-1));
        }

        [TestMethod()]
        public void FibTest_1()
        {
            Assert.AreEqual(1, Helpers.fib(1));
        }

        [TestMethod()]
        public void FibTest_2()
        {
            Assert.AreEqual(2, Helpers.fib(2));
        }
    }
}