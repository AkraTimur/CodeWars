using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Kata
    {
        public static int Factorial(int n)
        {
            if (n < 0 && n > 12) throw new System.ArgumentOutOfRangeException();
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        } 
    }
}
