using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrasshopperCombine
{
    public class Kata
    {
        public static string CombineNames(string a, string b) => $"{a} {b}";
    }
}

// alter: public static string CombineNames(params string[] names) => string.Join(" ", names);