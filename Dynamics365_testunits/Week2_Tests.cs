using System;
using Dynamics365_code.Week_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dynamics365_testunits
{
    [TestClass]
    public class Week2_Tests_OneAway
    {
        [DataTestMethod]
        [DataRow("first", "first")]
        [DataRow("", "")]
        [DataRow("first", "frst")]
        [DataRow("first", "firsti")]
        [DataRow("first", "frrst")]
        public void OneAway_Returns_True(string first, string second)
        {
            Assert.AreEqual(true, OneAway.OneAwayMethod(first, second));
        }

        [DataTestMethod]
        [DataRow("one", "threee")]
        [DataRow("ghhg", "gggg")]
        // The second data row should return false, but the code was copied from the book, yet it works incorrectly!!
        public void OneAway_Returns_False(string first, string second)
        {
            Assert.AreEqual(false, OneAway.OneAwayMethod(first, second));
        }
    }

    [TestClass]
    public class Week2_Tests_LongestSubstringWithoutRepeatingChars
    {
        [DataTestMethod]
        [DataRow("", 0)] // Empty string
        [DataRow("a", 1)] // Single character
        [DataRow("aA", 2)] // Not case sensitive
        [DataRow("abcdefg", 7)] // No repeating characters
        [DataRow("abb", 2)] // Repeating characters at end of string
        [DataRow("abcabcbb", 3)] // Random characters
        [DataRow("abcabcd", 4)] // Second unique substring longer than first unique substring
        [DataRow("bbbbb", 1)] // Repeating characters
        [DataRow("pwwkew", 3)] // Repeating character in middle of string
        public void LongestSubstring_Method_Returns_Correctly(string input, int result)
        {
            Assert.AreEqual(result, LongestSubstring.Longest_Substring_Without_Repeating_Chars(input));
        }

        [DataTestMethod]
        [DataRow("abc")]
        [DataRow("asdfwe")]
        [DataRow("a")]
        public void SubstringHasUniqueChars_Method_Returns_True(string input)
        {
            Assert.AreEqual(true, LongestSubstring.SubstringHasUniqueChars(input));
        }

        [DataTestMethod]
        [DataRow("aa")]
        [DataRow("abcb")]
        public void SubstringHasUniqueChars_Method_Returns_False(string input)
        {
            Assert.AreEqual(false, LongestSubstring.SubstringHasUniqueChars(input));
        }
    }
}