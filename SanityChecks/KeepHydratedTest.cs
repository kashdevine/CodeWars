using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeWars;

namespace SanityChecks
{
    public static class KeepHydratedTest
    {
        [Theory]
        [InlineData(3.0,1)]
        [InlineData(6.7, 3)]
        [InlineData(11.8, 5)]
        public static void Litres_Returns_TheSolutionRoundedToLowestInt(double time, int litres)
        {
            //arrange
            double sut = time;
            int expected = litres;

            //act
            int result =KeepHydrated.Litres(time);

            //assert
            Assert.Equal(expected, result);
        }
    }
}
