using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexpBasics
{
    public static class Kata
    {
        public static bool Digit(this string s) => Regex.IsMatch(s, "^[0-9]{1}\\z");

    }
}
