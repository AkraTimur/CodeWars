using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndStar
{
    internal class Kata
    {
        public static string TwoSort(string[] s)
        {
            var list = new List<string>();
            list = s.ToList();
            var res = list.OrderBy(x => x).FirstOrDefault();
            var str = "";
            foreach (var item in res)
            {
                if (item == res[res.Length - 1])
                {
                    str += item;
                    break;
                }
                    
                str += $"{item}***";
            }
            return str;
        }
    }
}
// not work