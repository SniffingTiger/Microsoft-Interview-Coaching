using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_code.Week_2
{
    public static class OneAway
    {
        public static bool OneAwayMethod(string first, string second)
        {
            // Return true if both strings are equal
            if (first.Equals(second))
                return true;

            else if (first.Length == second.Length)
                return OneReplace(first, second);

            else if (first.Length + 1 == second.Length)
                return OneInsert(first, second);

            else if (first.Length - 1 == second.Length)
                return OneInsert(second, first);

            else
                return false;
        }

        public static bool OneReplace(string first, string second)
        {
            Boolean foundDifference = false;
            for (int i = 0; i < first.Length; i++)
            {
                if (first.ElementAt(i) != second.ElementAt(i))
                {
                    if (foundDifference)
                        return false;
                }
            }
            return true;
        }

        public static bool OneInsert(string first, string second)
        {
            int index1 = 0;
            int index2 = 0;
            while (index2 < second.Length && index1 < first.Length)
            {
                if (first.ElementAt(index1) != second.ElementAt(index2))
                {
                    if (index1 != index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }
    }
}
