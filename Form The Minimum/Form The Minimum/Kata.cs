using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_The_Minimum
{
    public class Kata
    {
        public static long MinValue(int[] a)
        {
            Array.Sort(a);
            string num = "";
            for (int i = 0; i < a.Length; i++)
            {
                num = num + a[i];
            }
            var result = new string(num.Distinct().ToArray());
            return Convert.ToInt64(result);
            //Magic
        }
    }
}

//=> long.Parse(string.Concat(a.Distinct().OrderBy(x => x)));
