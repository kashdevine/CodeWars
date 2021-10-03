using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SanityChecks
{
    public static class DetetctPangramTest
    {
        
        [Theory]
        [InlineData("The quick brown fox jumps over the lazy dog.")]
        [InlineData("ABCD45EFGH,IJK,LMNOPQR56STUVW3XYZ")]
        public static void IsPangram_ReturnsTrue_IfStringIsPangram(string s)
        {
            //arrange
            string test = s;
            bool expected = true;
            //act
            bool result = DetetctPangram.IsPangram(test);
            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public static void IsPangram_ReturnsFalse_IfStringIsNotPangram()
        {
            //arrange
            string test = "This is hollywood.";
            bool expected = false;
            //act
            bool result = DetetctPangram.IsPangram(test);
            //assert
            Assert.Equal(expected, result);
        }
    }
}
