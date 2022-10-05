using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableMagic
{
    internal class Kata
    {
        public static bool Include(int[] arr, int item)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    res++;
                }  
            }
            return res > 0;

            // or  return arr/Comtains(item)
           
        }
    }
}
