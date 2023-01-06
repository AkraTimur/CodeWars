using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Minimums
{
    public class Kata
    {
        public static int SumOfMinimums(int[,] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                var min = numbers[i, 0];
                for (int j = 1; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] < min)
                        min = numbers[i, j];
                }
                sum += min;
            }
            return sum;
        }
    }
}
