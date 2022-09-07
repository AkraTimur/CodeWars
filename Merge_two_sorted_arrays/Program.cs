using System;

namespace Merge_two_sorted_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int [] answer = Kata.MergeArrays(new[] { 1, 3, 5, 7, 9, 11, 12 }, new[] { 1, 2, 3, 4, 5, 10, 12 });

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
