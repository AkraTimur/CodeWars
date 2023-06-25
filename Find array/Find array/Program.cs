namespace Find_array_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Kata.FindArray(new object[] { 1, 2, 3, 4, 5 }, new int[] { 4, 2, 0 });

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}