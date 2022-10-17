namespace Number_of_People_in_the_Bus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, 
                new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, 
                new[] { 6, 1 }, new[] { 7, 10 } };

            Console.WriteLine(Kata.Number(peopleList));
        }
    }
}