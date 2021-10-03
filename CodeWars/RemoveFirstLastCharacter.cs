using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class RemoveFirstLastCharacter
    {
        public static string Remove_char(string s)
        {
            List<char> returningChars = new List<char>();
            char[] stringChar = s.ToArray();

           for(int i=0; i< stringChar.Length; i++)
            {
                if(i != 0 && i != stringChar.Length - 1)
                {
                    returningChars.Add(stringChar[i]);
                }
            }


            string returningString = new string(returningChars.ToArray());

            return returningString;
            
        }
    }
}
