namespace Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Kata.PowersOfTwo(37);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}