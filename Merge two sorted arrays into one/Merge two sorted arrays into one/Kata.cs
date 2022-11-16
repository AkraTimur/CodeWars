using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_two_sorted_arrays_into_one
{
    public class Kata
    {
        public static T[] Concat<T>(params T[][] arrays)
        {
            var result = new T[arrays.Sum(a => a.Length)];
            int offset = 0;
            foreach (T[] array in arrays)
            {
                array.CopyTo(result, offset);
                offset += array.Length;
            }
            return result;
        }
        public static int[] MergeArrays(int[] firstArray, int[] secondArray)
        {

            return Concat(firstArray, secondArray);

        }
    }
}
