using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class OnesAndZeros
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            string binary = string.Join(string.Empty, BinaryArray);
            return Convert.ToInt32(binary, 2);
        }
    }
}
