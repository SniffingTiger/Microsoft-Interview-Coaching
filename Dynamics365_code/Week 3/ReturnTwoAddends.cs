using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_code.Week_3
{
    public static class ReturnTwoAddends
    {
        public static int[] ReturnTwoAddendsMethod(int[] inputArr, int sum)
        {
            if (inputArr.Length == 1 || inputArr.Length == 0 || inputArr is null)
            {
                throw new InvalidOperationException("You must input an integer array with at least two integers in it");
            }

            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    if (inputArr[j] + inputArr[i] == sum)
                    {
                        return new int[] { inputArr[i], inputArr[j] };
                    }
                }
            }

            // If no array items add up to them sum, this method will return an empty array
            return new int[] { };
        }
    }
}
