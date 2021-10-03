using System;


namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "xyaabbbccccdefww";
            string s2 = "xxxxyyyyabklmopq";
            string result = TwotoOne.Longest(s1, s2);

            Console.WriteLine(result);
        }
    }
}
