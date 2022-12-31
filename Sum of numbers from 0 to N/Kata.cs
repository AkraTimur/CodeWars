using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_numbers_from_0_to_N
{
    public class Kata
    {
        public static string ShowSequence(int n)
        {
            if (n < 0) return $"{n}<0";
            if (n == 0) return $"{n}=0";

            var list = new List<int>();

            for (int i = 0; i <= n; i++)
            {
                list.Add(i);
            }

            return $"{string.Join("+", list.ToArray())} = {list.Sum()}";
        }
    }
}
