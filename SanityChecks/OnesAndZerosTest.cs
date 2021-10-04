using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeWars;

namespace SanityChecks
{
    public static class OnesAndZerosTest
    {
        [Theory]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 15)]
        public static void binaryArrayToNumber_Returns_CorrectIntfromBinary(int[] input, int output)
        {
            //arrange
            int[] sut = input;
            int expected = output;
            //act
            int result = OnesAndZeros.binaryArrayToNumber(sut);
            //assert
            Assert.Equal(expected, result);
        }
    }
}
