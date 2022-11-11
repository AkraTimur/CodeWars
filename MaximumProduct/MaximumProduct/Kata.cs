using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumProduct
{
    public class Kata
    {
        public static int AdjacentElementsProduct(int[] array)
        {
            var list = array.ToList();
            var myList = new List<int>();
            int res = 0;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                        res = array[j] * array[i];
                        myList.Add(res);
                    i++;
                }
            }
            if (list[list.Count-1] == 0) return myList.Max();
            if (res == 0) return res;
            return myList.Max();
        }

    }
}
// return array.Skip(1).Select((x,i) => x * array[i]).Max();
