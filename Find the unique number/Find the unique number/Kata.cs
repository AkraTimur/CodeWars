using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_unique_number
{
    public class Kata
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
           return numbers.First(x => numbers.Count(i => i == x) == 1);
        }
    }
}
