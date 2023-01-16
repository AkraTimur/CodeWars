using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_diff___easy
{
    internal class Kata
    {
        public static int MaxDiff(int[] lst)
        {
            return lst.Length > 2 ? lst.Max() - lst.Min() : 0;

        }
    }
}
