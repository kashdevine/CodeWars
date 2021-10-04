using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class IQTest
    {
        public static int Test(string numbers)
        {
            List<int> indexesofOdds = new List<int>();
            List<int> indexesofEvens = new List<int>();

            string[] nums = numbers.Split(" ");

            foreach(string c in nums)
            {
                int currentNum = 0;

                int.TryParse(c, out currentNum);

                if(currentNum % 2 == 0)
                {
                    int evenlocation = Array.IndexOf(nums, c) + 1;
                    indexesofEvens.Add(evenlocation);
                }
                else
                {
                    int oddLocation = Array.IndexOf(nums, c) + 1;
                    indexesofOdds.Add(oddLocation);
                }
            }

            if(indexesofEvens.Count == 1)
            {
                return indexesofEvens[0];
            }
            else
            {
                return indexesofOdds[0];
            }

        }
    }
}
