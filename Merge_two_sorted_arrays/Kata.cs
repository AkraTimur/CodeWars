using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Merge_two_sorted_arrays
{
    internal class Kata
    {
        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int indexArr1 = 0;
            int indexArr2 = 0;
            if (arr1.Length == 0) return arr2;
            if (arr2.Length == 0) return arr1;

            for (int i = 0; i < arr3.Length; i++)
            {
                if (indexArr1 < arr1.Length && arr1[indexArr1] <= arr2[indexArr2])
                {
                    arr3[i] = arr1[indexArr1];
                    indexArr1++;
                }
                else
                {
                    if (indexArr2 < arr2.Length)
                    {
                        arr3[i] = arr2[indexArr2];
                        indexArr2++;
                    }

                }
            }
            return arr3;

        }
    }
}
