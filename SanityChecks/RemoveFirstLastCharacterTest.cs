using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SanityChecks
{
    public static class RemoveFirstLastCharacterTest
    {
        [Fact]
        public static void Remove_char_Returns_StringWithoutFirstLastChar()
        {
            //arrange
            string s = "cow";
            string expected = "o";

            //act
            string result = RemoveFirstLastCharacter.Remove_char(s);

            //assert
            Assert.Equal(expected, result);
        }
    }
}
