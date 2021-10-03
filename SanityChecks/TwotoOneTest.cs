using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SanityChecks
{
    public static class TwotoOneTest
    {
        [Fact]
        public static void Longest_ReturnsLongestUniqueString()
        {
            //arrange
            string s1 = "xyaabbbccccdefww";
            string s2 = "xxxxyyyyabklmopq";
            string expected = "abcdefklmopqwxy";
            //act
            string result = TwotoOne.Longest(s1, s2);
            //assert
            Assert.Equal(expected, result);
        }
    }
}
