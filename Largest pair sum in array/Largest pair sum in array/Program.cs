namespace Largest_pair_sum_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.LargestPairSum(new int[] { -8, -8, -16, -18, -19 }));
            Console.WriteLine(Kata.LargestPairSum(new int[] { -100, -29, -24, -19, 19 }));
        }
    }
}

//Largest pair sum in array

//Given a sequence of numbers, find the largest pair sum in the sequence.

//For example

//[10, 14, 2, 23, 19] --> 42(= 23 + 19)
//[99, 2, 2, 23, 19]-- > 122(= 99 + 23)
//Input sequence contains minimum two elements and every element is an integer.
