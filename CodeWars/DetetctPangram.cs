using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class DetetctPangram
    {
        public static bool IsPangram(string str)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] charsToTrim = {'.', '!', '?', '(',')', ',', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            
            

           char[] justLetters =  str.ToLower()
                .Trim(charsToTrim)
                .Replace(" ", "")
                .Distinct()
                .ToArray();

            Array.Sort(justLetters);



            string sortedInputString = new string(justLetters);

            if (sortedInputString.Length != 26)
            {
                foreach (char c in sortedInputString)
                {
                    if (charsToTrim.Contains(c))
                    {
                        int removeIndex = sortedInputString.IndexOf(c);
                        sortedInputString = sortedInputString.Remove(removeIndex,1);
                    }
                }
            }


            if (alphabet == sortedInputString)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
