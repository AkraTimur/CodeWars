namespace Cats_in_hats
{
    internal class Program
    {

        public static string Height(int n)
        {
            decimal oneCat = 2000000;
            decimal totalHeight = oneCat;

            for (int i = 1; i <= n; i++)
            {
                oneCat /= 2.5m;
                totalHeight += oneCat;
            }

            return totalHeight.ToString("F3");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Height(7));
        }
    }
}