using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexValidate
{
    public class Kata
    {
        public static bool ValidatePin(string pin) => Regex.IsMatch(pin, @"^[0-9]{4}$|^[0-9]{6}$");
    }
}
