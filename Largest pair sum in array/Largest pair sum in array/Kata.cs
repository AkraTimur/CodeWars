using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_pair_sum_in_array
{
    public class Kata
    {
        public static int LargestPairSum(int[] numbers)
        {
            var resList = new List<int>();
            int res = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                    res = numbers[i] + numbers[i-1];
                    resList.Add(res);
            }
            return resList.Max();
        }
    }
}
//var resList = new List<int>();
//int res = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    for (int j = i + 1; i < numbers.Length/2; i++)
//    {
//        res = numbers[i] + numbers[j];
//        resList.Add(res);
//        j++;

//    }
//} 
//return resList.Max();   

//var lisT = numbers.Aggregate((x, y) => x + y);