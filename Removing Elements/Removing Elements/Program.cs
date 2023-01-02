namespace Removing_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Kata.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" });
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}