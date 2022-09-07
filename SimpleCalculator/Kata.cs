using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    internal class Kata
    {
        public static double Calculator(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                    break;
                case '-':
                    return a - b;
                    break;
                case '*': return a * b;
                    break;
                case '/':
                    return a / b;
                    break;
                default:
                    throw new ArgumentException(String.Format("{0} is not correct", op),
                                      "op");
            }

        }
    }
}
