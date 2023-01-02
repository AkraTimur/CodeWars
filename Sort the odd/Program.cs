namespace Sort_the_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 });
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
//Task
//You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.
