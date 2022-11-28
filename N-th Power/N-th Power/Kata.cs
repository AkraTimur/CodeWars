using System;
using System.Collections.Generic;
using System.Text;

namespace N_th_Power
{
    public static class Kata
    {
        public static double Index(int[] array, int n)
        {
            if (n > array.Length - 1) return (double)-1;
            return Math.Pow((double)array[n], (double)n);
        }
    }
}
//  => n < array.Length ? Math.Pow(array[n],n) : -1;