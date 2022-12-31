using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace validate_code_with_simple_regex
{
    public static class Kata
    {
        public static bool ValidateCode(string code)
        {
            return Regex.IsMatch(code, "^[1-3]");
        }
    }
}
