using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_code.Week_1
{
    public static class ATOI_ITOA
    {
        public static int Atoi(string input)
        {
            int output = 0;
            int canParse = 0;
            bool isInt = Convert.ToBoolean(Int32.TryParse(input, out canParse));
            if (isInt)
            {
                output = Convert.ToInt32(input);
                return output;
            }
            else
            {
                throw new InvalidCastException();
            }
        }

        public static string Itoa(int input)
        {
            if (input == 0)
            {
                return new string('0', 1);
            }
            else if (input > 0)
            {
                int numberOfTenPlaces = 1;
                int inputCopy = input;
                while (inputCopy >= 10)
                {
                    inputCopy /= 10;
                    numberOfTenPlaces++;
                }
                char[] intToCharArray = new char[numberOfTenPlaces];

                int charArrayCounter = 0;
                while (input > 0)
                {
                    char next = (char)((input % 10).ToString()[0]);
                    input /= 10;
                    intToCharArray[charArrayCounter] = next;
                    charArrayCounter++;
                }

                Array.Reverse(intToCharArray);
                string output = new string(intToCharArray);
                return output;
            }

            else if (input < 0)
            {
                int numberOfTenPlaces = 1;
                int inputCopy = input;
                while (inputCopy < -10)
                {
                    inputCopy /= 10;
                    numberOfTenPlaces++;
                }
                char[] intToCharArray = new char[numberOfTenPlaces+1];
                intToCharArray[0] = '-';

                int charArrayCounter = 1;
                while (input > 0)
                {
                    char next = Convert.ToChar(input % 10);
                    input /= 10;
                    intToCharArray[charArrayCounter] = next;
                    charArrayCounter++;
                }

                string output = new string(intToCharArray);
                return output;
            }

            // This code line below should never ever happen!!
            // It is only written so that the method will compile
            return "";
            
        }

    }
}
