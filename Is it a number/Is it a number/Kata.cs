using System;
using System.Collections.Generic;
using System.Text;

namespace Is_it_a_number
{
    public class Kata
    {
        public static bool IsDigit(string s) => double.TryParse(s, out _);
    }
}
