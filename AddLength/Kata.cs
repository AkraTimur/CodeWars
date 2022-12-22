using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddLength
{
    public class Kata
    {
        public static string[] AddLength(string str)
        {
            var array = str.Split();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = $"{array[i]} {array[i].Length}";
            }
            return array;
        }
    }
}
//=> str.Split(' ').Select(e=> $"{e} {e.Length}").ToArray();