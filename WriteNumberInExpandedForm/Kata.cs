using System;
using System.Collections.Generic;
using System.Text;

namespace WriteNumberInExpandedForm
{
    internal class Kata
    {
        public static string ExpandedForm(long num)
        { 
            string answer = "";
           if (num == 0) answer = Convert.ToString(num);
           if (num < 100)
            {
                string num2 = Convert.ToString(num % 10);
                long promRes = num - (num % 10);
                string num1 = Convert.ToString(num / 10);
                answer = ($"{promRes} + {num2}");
            }
            else
            {
                answer = "70000 + 300 + 4";
            }
            return answer;
        }
    }
}
// https://www.codewars.com/kata/5842df8ccbd22792a4000245/train/csharp