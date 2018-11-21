using System;
using Dynamics365_code.Week_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dynamics365_testunits
{
    [TestClass]
    public class Week1_Tests_atoi
    {
        [DataTestMethod]
        [DataRow("s")]
        [DataRow("string")]
        [DataRow("12b")]
        [DataRow("-2147483649")]
        [DataRow("2147483648")]
        [ExpectedException(typeof(InvalidCastException))]
        public void Atoi_Should_Throw_Exception(string input)
        {
            ATOI_ITOA.Atoi(input);
        }

        [DataTestMethod]
        [DataRow("1", 1)]
        [DataRow("1000", 1000)]
        [DataRow("-2147483648", -2147483648)]
        [DataRow("2147483647", 2147483647)]
        public void Atoi_Should_Succeed(string input, int output)
        {
            Assert.AreEqual(ATOI_ITOA.Atoi(input), output);
        }
    }

    [TestClass]
    public class Week1_Tests_itoa
    {
        [DataTestMethod]
        [DataRow(0, "0")]
        [DataRow(4, "4")]
        [DataRow(100, "100")]
        [DataRow(1000000, "1000000")]
        [DataRow(2123123, "2123123")]
        public void Itoa_Succeeds(int input, string output)
        {
            Assert.AreEqual(ATOI_ITOA.Itoa(input), output);
        }
    }

    [TestClass]
    public class Week1_Tests_IsPalindrome
    {
        [DataTestMethod]
        [DataRow(3)]
        [DataRow(444)]
        [DataRow(121)]
        [DataRow(21)]
        [DataRow(1234)]
        [DataRow(19)]
        public void IsPalindrome_Returns_True(int number)
        {
            Assert.AreEqual(IsPalindromeClass.IsOrCanBePalindrome(number), true);
        }

        [DataTestMethod]
        [DataRow(999998)]
        [DataRow(90089)]
        [DataRow(1000001)]
        public void IsPalindrome_Returns_False(int number)
        {
            Assert.AreEqual(IsPalindromeClass.IsOrCanBePalindrome(number), false);
        }
    }

    [TestClass]
    public class Week1_Tests_ReverseParseMulti_Byte
    {
        [DataTestMethod]
        [DataRow("pi")]
        [DataRow("string")]
        [DataRow("op")]
        public void NumChars_Returns_1(string input)
        {
            char[] inputCharArray = input.ToCharArray();
            int result = ReverseParseMulti_Byte.NumChars(inputCharArray);

            Assert.AreEqual(1, result);
        }

        [DataTestMethod]
        [DataRow("に")]
        [DataRow("ほ")]
        [DataRow("ん")]
        [DataRow("Ѱ")] // Cyrillic characters is also double-byte apparently
        public void NumChars_Returns_2(string input)
        {
            char[] inputCharArray = input.ToCharArray();
            int result = ReverseParseMulti_Byte.NumChars(inputCharArray);

            Assert.AreEqual(2, result);
        }
    }
}