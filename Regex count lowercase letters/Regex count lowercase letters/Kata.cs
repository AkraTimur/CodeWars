using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_count_lowercase_letters
{
    public class Kata
    {
        public static int LowercaseCountCheck(string s)
        {
            return Regex.Matches(s, "[a-z]").Count();
            // your code goes here ...
        }
    }
}
