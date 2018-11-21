using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_code.Week_2
{
    public static class LongestSubstring
    {
        public static int Longest_Substring_Without_Repeating_Chars(string input)
        {
            int longestSubstringLength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j <= input.Length; j++)
                {
                    string substring = input.Substring(i, j - i);
                    if (SubstringHasUniqueChars(substring))
                    {
                        if (substring.Length > longestSubstringLength)
                        {
                            longestSubstringLength = substring.Length;
                        }
                    }
                }
            }
            return longestSubstringLength;
        }

        public static bool SubstringHasUniqueChars(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j <= input.Length -1; j++)
                {
                    if (input[i] == input[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}