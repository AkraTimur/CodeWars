using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_to_One
{
    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            return string.Join("", s1.Concat(s2).Distinct().OrderBy(x => x).ToList());
        }
    }
}
