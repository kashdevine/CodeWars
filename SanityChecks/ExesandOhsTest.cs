using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeWars;

namespace SanityChecks
{
    public static class ExesandOhsTest
    {
        [Theory]
        [InlineData("ooxx", true)]
        [InlineData("xooxx", false)]
        [InlineData("ooxXm", true)]
        [InlineData("zpzpzpp", true)]
        [InlineData("zzoo", false)]
        public static void XO_Returns_CorrectBoolForCounts(string input, bool e)
        {
            //arrange
            string sut = input;
            bool expected = e;

            //act
            bool result = ExesandOhs.XO(sut);

            //assert
            Assert.Equal(expected, result);
        }
    }
}
