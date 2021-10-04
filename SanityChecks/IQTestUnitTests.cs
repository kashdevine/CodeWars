using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeWars;

namespace SanityChecks
{
    public static class IQTestUnitTests
    {
        [Theory]
        [InlineData("2 4 7 8 10", 3)]
        [InlineData("1 2 1 1", 2)]
        public static void IQTest_Returns_IndexofOddNumber(string numbers, int index)
        {
            //arrange
            string testNums = numbers;
            int expected = index;
            //act
            int result = IQTest.Test(testNums);

            //assert
            Assert.Equal(expected, result);
        }
    }
}
