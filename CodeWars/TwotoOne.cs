using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class TwotoOne
    {
        public static string Longest(string s1, string s2)
        {
            List<char> sharedChars = new List<char>();
            char[] charS1 = s1.ToCharArray();
            char[] charS2 = s2.ToCharArray();
            
            foreach(char c in charS1)
            {
                if (!sharedChars.Contains(c))
                {
                    sharedChars.Add(c);
                }
            }

            foreach(char c in charS2)
            {
                if (!sharedChars.Contains(c))
                {
                    sharedChars.Add(c);
                }
            }

            char[] charArray = sharedChars.ToArray();

            Array.Sort(charArray);

            string finalString = new string(charArray);

            return finalString;
        }
    }
}
