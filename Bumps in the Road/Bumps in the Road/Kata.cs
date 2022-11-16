using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bumps_in_the_Road
{
    public class Kata
    {
        public static string Bump(string input)
        {
            var pattern = "n";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            if (matches.Count > 15) return "Car Dead";
            else return "Woohoo!";
        }
    }
}
