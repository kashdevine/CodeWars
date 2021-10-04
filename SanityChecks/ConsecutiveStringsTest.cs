using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeWars;

namespace SanityChecks
{
    public static class ConsecutiveStringsTest
    {
        [Theory]
        [InlineData(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2,"abigailtheta" )]
        [InlineData(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1, "oocccffuucccjjjkkkjyyyeehh")]
        [InlineData(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2, "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck")]
        [InlineData(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3, "ixoyx3452zzzzzzzzzzzz")]
        public static void LongestConcet_Returns_LongConcatOfStrings(string[] strarr, int k, string output)
        {
            //arrange
            string[] input = strarr;
            string expected = output;
            //act
            string result = ConsecutiveStrings.LongestConcet(input, k);

            //assert
            Assert.Equal(expected, result);
        }
    }
}
