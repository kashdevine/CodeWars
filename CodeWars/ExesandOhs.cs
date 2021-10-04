using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class ExesandOhs
    {
        public static bool XO(string input)
        {
            
            int Xs = input.ToLower().Count(x => x == 'x');
            int Ohs = input.ToLower().Count(o => o == 'o');

            return Xs == Ohs;
        }
    }
}
