namespace MaximumProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine(Kata.AdjacentElementsProduct(new int[]{ 9, 5, 10, 2, 24, -1, -48 }));
            Console.WriteLine(Kata.AdjacentElementsProduct(new int[]{ 6, 1, 3, 1, 0}));
        }
    }
}

//Task
//Given an array of integers , Find the maximum product obtained from multiplying 2 adjacent numbers in the array.

//Notes
//Array/list size is at least 2.

//Array/list numbers could be a mixture of positives, negatives also zeroes .

//Input >> Output Examples
//adjacentElementsProduct([1, 2, 3]); ==> return 6
//Explanation:
//The maximum product obtained from multiplying 2 * 3 = 6, and they're adjacent numbers in the array.
//adjacentElementsProduct([9, 5, 10, 2, 24, -1, -48]); ==> return 50
//Explanation:
//Max product obtained from multiplying 5 * 10  =  50 .


