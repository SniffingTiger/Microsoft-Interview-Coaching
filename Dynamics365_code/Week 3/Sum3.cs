using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_code.Week_3
{
    public static class Sum3
    {
        public static List<int[]> Sum3Method(int[] inputArr, int sum)
        {
            if (inputArr == null || inputArr.Length < 3)
            {
                return null;
            }

            List<int[]> result = new List<int[]>();

            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    for (int k = j+1; k < inputArr.Length; k++)
                    {
                        if (inputArr[i] + inputArr[j] + inputArr[k] == sum)
                        {
                            int[] newArray = new int[3] { inputArr[i], inputArr[j], inputArr[k] };
                            Array.Sort(newArray);
                            if (!result.Contains(newArray))
                            {
                                result.Add(newArray);
                            }
                        }
                    }
                }
            }
            if (result.Count != 0)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
