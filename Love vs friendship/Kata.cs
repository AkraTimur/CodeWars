using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Love_vs_friendship
{
    internal class Kata
    {
        public static int WordsToMarks(string str)
        {
            var list = new List<int>();
            var arr = str.ToCharArray();
            var smbl = 0;

            foreach (var item in arr)
            {
                smbl = (int)item % 32;
                list.Add(smbl);
            }
            return list.Sum();
        }
    }
}
// public static int WordsToMarks(string str) => str.Sum(c => c - 96);
