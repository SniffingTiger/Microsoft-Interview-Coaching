using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_code.Week_1
{
    public class IsPalindromeClass
    {
        private static int Reverse(int original)
        {
            int reverse = 0;
            while (original != 0)
            {
                int digit = original % 10;
                reverse = reverse * 10 + digit;
                original = original / 10;
            }
            return reverse;
        }

        private static bool IsPalindrome(int original, int reverse)
        {
            return original == reverse;
        }


        // IMPORTANT! This method does not return false for the following test inputs: "gggg", "ghhg"
        // This code has been copied directly from Dyamics 365, yet it does not work correctly
        public static bool IsOrCanBePalindrome(int number)
        {
            const int MaxPalindrome = 1000000;

            while (number < MaxPalindrome)
            {
                int reverse = Reverse(number);
                bool isPal = IsPalindrome(number, reverse);
                if (isPal)
                {
                    return true;
                }

                number = number + reverse;
            }

            return false;
        }
    }
}
