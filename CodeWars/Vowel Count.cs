using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class Vowel_Count
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            char[] vowels = {'a','e','i','o','u' };
            foreach (char c in str)
            {
                if (vowels.Contains(c)){
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
