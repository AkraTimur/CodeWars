using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summing_a_number_s_digits
{
    public class Kata
    {
        public static int SumDigits(int number)
        {
            if(number < 0) number *= -1;
            if(number < 10) return number;
            if(number < 100)
            {
                var firstNum = number / 10;
                var secondNum = number % 10;
                return firstNum + secondNum;
            }
            var digits = Convert.ToString(number);
            var num = digits.ToCharArray();
            var aInt = num.Select(i => Int32.Parse(i.ToString())).ToArray();
            return aInt.Sum();
        }
    }
}
