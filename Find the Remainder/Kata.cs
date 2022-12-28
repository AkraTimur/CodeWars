using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Remainder
{
    public class Kata
    {
        public static int Remainder(int a, int b)
        {
            int number = 0;
            int divaider = 0;
            if(a > b)
            {
                number = a;
                divaider = b;
            }
            else
            {
                number = b;
                divaider = a;
            }
            if (divaider == 0) throw new DivideByZeroException();
            return number % divaider;

        }
    }
}
