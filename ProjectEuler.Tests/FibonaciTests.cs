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
    public class FibonaciTests
    {
        [TestMethod()]
        public void FibonacciRecursiveTest_0()
        {
            Assert.AreEqual(0, Helpers.FibonacciRecursive(0));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "A userId of null was inappropriately allowed.")]
        public void FibonacciRecursiveTest_Negative()
        {
            Assert.AreEqual(0, Helpers.FibonacciRecursive(-1));
        }

        [TestMethod()]
        public void FibonacciRecursiveTest_1()
        {
            Assert.AreEqual(1, Helpers.FibonacciRecursive(1));
        }

        [TestMethod()]
        public void FibonacciRecursiveTest_2()
        {
            Assert.AreEqual(2, Helpers.FibonacciRecursive(2));
        }
        [TestMethod()]
        public void FibonacciRecursiveTest_10()
        {
            Assert.AreEqual(89, Helpers.FibonacciRecursive(10));
        }








        [TestMethod()]
        public void FibonacciIterativeTest_0()
        {
            Assert.AreEqual(0, Helpers.FibonacciIterative(0));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "A userId of null was inappropriately allowed.")]
        public void FibonacciIterativeTest_Negative()
        {
            Assert.AreEqual(0, Helpers.FibonacciIterative(-1));
        }

        [TestMethod()]
        public void FibonacciIterativeTest_1()
        {
            Assert.AreEqual(1, Helpers.FibonacciIterative(1));
        }

        [TestMethod()]
        public void FibonacciIterativeTest_2()
        {
            Assert.AreEqual(2, Helpers.FibonacciIterative(2));
        }
        [TestMethod()]
        public void FibonacciIterativeTest_10()
        {
            Assert.AreEqual(89, Helpers.FibonacciIterative(10));
        }

        [TestMethod]
        public void FibonaciListTest_1()
        {
            CollectionAssert.AreEqual(new List<int> { 1 }, Helpers.FibonaciNumbers(1).ToList());
        }

        [TestMethod]
        public void FibonaciListTest_10()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 }, Helpers.FibonaciNumbers(10).ToList());
        }
    }
}