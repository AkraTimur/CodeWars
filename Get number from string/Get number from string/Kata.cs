using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Get_number_from_string
{
    class Kata
    {
        public static int getNumberFromString(string s) => Convert.ToInt32(string.Join("", s.ToCharArray().Where(Char.IsDigit)));
    }
}
 