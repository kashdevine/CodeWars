using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class KeepHydrated
    {
        public static int Litres(double time)
        {
            return (int)Math.Floor(time * 0.5);
        }
    }
}
