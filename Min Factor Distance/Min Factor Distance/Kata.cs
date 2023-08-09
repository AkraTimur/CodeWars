using System.Collections.Generic;

namespace Min_Factor_Distance
{
    public static class Kata
    {
        public static int MinDistance(int n)
        {
            var array = new List<int>();

            for (int count = 1; count < n+1; count++)
            {
                if(n % count == 0)
                {
                    array.Add(count);
                }
            }

            var minDifference = array.SelectMany((a, i) => array.Skip(i + 1), (a, b) => Math.Abs(a - b)).Min();

            return minDifference;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Kata.MinDistance(13013));
        }
    }
}