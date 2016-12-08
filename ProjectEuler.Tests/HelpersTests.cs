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

        [TestMethod()]
        public void IsPalindromeTest_abba()
        {
            Assert.IsTrue(Helpers.IsPalindrome("abba"));
        }

        [TestMethod()]
        public void IsPalindromeTest_123321()
        {
            Assert.IsTrue(Helpers.IsPalindrome(123321));
        }

        [TestMethod()]
        public void IsPalindromeTest_123322()
        {
            Assert.IsFalse(Helpers.IsPalindrome(123322));
        }

        [TestMethod()]
        public void IsPalindromeTest_1230321()
        {
            Assert.IsTrue(Helpers.IsPalindrome(1230321));
        }
    }
}