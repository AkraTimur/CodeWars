using System;

namespace Build_a_pile_of_Cubes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static long findNb(long m)
        {
            long sum = 0;
            int n = 0;
            while (sum < m)
            {
                n++;
                sum += (long)Math.Pow(n, 3);
            }
            if (sum == m)
                return n;
            else
                return -1;
        }
    }
    
}
