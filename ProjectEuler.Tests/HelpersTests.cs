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
        public void IsAFactorOfBTest_2_4()
        {
            Assert.IsTrue(Helpers.IsAFactorOfB(2, 4));
        }

        [TestMethod()]
        public void IsAFactorOfBTest_2_5()
        {
            Assert.IsFalse(Helpers.IsAFactorOfB(2, 5));
        }

        [TestMethod()]
        public void IsPrimeTest_29()
        {
            Assert.IsTrue(Helpers.IsPrime(29));
        }
        [TestMethod()]
        public void IsPrimeTest_99()
        {
            Assert.IsFalse(Helpers.IsPrime(99));
        }

        [TestMethod()]
        public void IsPrimeTest_349()
        {
            Assert.IsTrue(Helpers.IsPrime(349));
        }
        [TestMethod()]
        public void IsPrimeTest_1000()
        {
            Assert.IsFalse(Helpers.IsPrime(1000));
        }

    }
}