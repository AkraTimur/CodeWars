using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mumbling
{
    internal class Kata
    {
        public static String Accum(string s)
        {
            return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        }
    }
}
