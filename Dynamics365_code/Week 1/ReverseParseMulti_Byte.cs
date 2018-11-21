using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365_code.Week_1
{
    public static class ReverseParseMulti_Byte
    {
        public static int NumChars(char[] engOrJapChars)
        {
            byte[] lastTwoBytes = Encoding.UTF8.GetBytes(engOrJapChars);

            byte highByte = lastTwoBytes[lastTwoBytes.Length - 2];
            byte lowByte = lastTwoBytes[lastTwoBytes.Length - 1];

            if (((highByte & (1 << 7)) != 0) && (((lowByte & (1 << 7)) == 0) || ((lowByte & (1 << 7)) != 0)))
            {
                return 2;
            }
            
            else if (((highByte & (1 << 7)) == 0 ) && ((lowByte & (1 << 7)) == 0))
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }
    }
}