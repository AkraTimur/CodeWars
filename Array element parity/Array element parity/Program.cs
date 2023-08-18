using System.ComponentModel.DataAnnotations;

namespace Array_element_parity
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Kata
    {
        public static int Solve(List<int> arr)
        {
            // Используем LINQ для нахождения элемента, который не имеет пары с противоположным знаком
            return arr.FirstOrDefault(x => !arr.Contains(-x));
        }
    }
}