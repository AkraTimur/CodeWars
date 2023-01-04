namespace Build_Tower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Kata.TowerBuilder(3);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}