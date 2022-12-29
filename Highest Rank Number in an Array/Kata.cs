using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Highest_Rank_Number_in_an_Array
{
    public class Kata
    {
        public static int HighestRank(int[] arr)
        {

            var res = arr.GroupBy(x => x)
                          .ToDictionary(x => x.Key, y => y.Count())
                          .OrderByDescending(x => x.Value)
                          .ThenByDescending(x => x.Key)
                          .Select(x => x.Key)
                          .ToList()
                          .FirstOrDefault(); 
            return res;
        }
    }
}
