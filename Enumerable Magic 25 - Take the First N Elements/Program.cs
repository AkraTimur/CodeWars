namespace Enumerable_Magic_25___Take_the_First_N_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Kata.Take(new int[] { }, 3);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
//Enumerable Magic #25 - Take the First N Elements
//Create a function that accepts a list/array and a number n, and returns a list/array of the first n elements from the 
//list/array.