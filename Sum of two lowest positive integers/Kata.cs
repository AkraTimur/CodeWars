using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_two_lowest_positive_integers
{
    public class Kata
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            var minOne = numbers.Min();
            var minTwo = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == minOne)
                {
                    numbers[i] = 999999999;
                }
            }
            minTwo = numbers.Min();

            return minOne + minTwo;
        }
    }
}


// or  return numbers.OrderBy(i => i).Take(2).Sum();