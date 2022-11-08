using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_without_highest_and_lowest_number
{
    public class Kata
    {
        public static int Sum(int[] numbers)
        {
            if ((numbers == null) || (numbers.Length <= 1))
            {
                return 0;
            }
            return numbers.Sum() - numbers.Min() - numbers.Max(); 
        }
    }
}
