using System;
using System.Collections.Generic;
using System.Text;

namespace Take_the_Derivative
{
    public class Kata
    {
        public static string Derive(double coefficient, double exponent) => $"{coefficient * exponent}x^{exponent - 1}";
    }
}
