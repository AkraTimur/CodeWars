using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_words
{
    public class Kata
    {
        public static string ReverseWords(string str)
        {
            return string
            .Join(" ", str
            .Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));
        }
    }
}
