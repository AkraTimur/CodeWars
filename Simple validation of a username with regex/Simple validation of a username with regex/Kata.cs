using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Simple_validation_of_a_username_with_regex
{
    public class Kata
    {
        public static bool ValidateUsr(string username)
        {
            string pattern = "^[a-z\\d_-]{4,16}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(username);
        }
    }
}
