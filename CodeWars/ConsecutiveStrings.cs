using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class ConsecutiveStrings
    {
        public static string LongestConcet(string[] strarr, int k)
        {
            int n = strarr.Length;
            List<string> longStrings = new List<string>();
            int originalK = k;

            if(n == 0 || k > n || k <= 0)
            {
                return "";
            }

            if (k == 1)
            {
                for(int i=0; i<n; i++)
                {
                    string temp = strarr[i];

                    if (longStrings.Count == 0)
                    {
                        longStrings.Add(temp);
                    }

                    else if (temp.Length > longStrings[0].Length)
                    {
                        longStrings.Insert(0, temp);
                    }

                    else if (temp.Length == longStrings[0].Length)
                    {
                        continue;
                    }
                }

                return longStrings[0];

            }

            for (int i=0; i < n; i++)
            {
                string temp = string.Empty;



                int j = i + 1;
                int m = j + 1;


                if (j >= n)
                {
                    return longStrings[0];
                }

                temp = strarr[i] + strarr[j];

                while(k>2)
                {
                    if (m >= n)
                    {
                        return longStrings[0];
                    }
                    temp = temp + strarr[m];
                    m++;
                    k--;
                }

                if (longStrings.Count == 0)
                {
                    longStrings.Add(temp);
                }

                else if(temp.Length > longStrings[0].Length)
                {
                    longStrings.Insert(0, temp);
                }
                
                else if(temp.Length == longStrings[0].Length)
                {
                    continue;
                }

                k = originalK;
            }


            return longStrings[0];
        }
    }
}
