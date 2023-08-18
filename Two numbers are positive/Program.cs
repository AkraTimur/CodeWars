namespace Two_numbers_are_positive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public static class Kata
    {
        public static bool TwoArePositive(int a, int b, int c)
        {
            var list = new List<int> 
            {
                a, b, c
            };
            int flag = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]> 0)
                {
                    flag++;
                }
            }

            return flag == 2;
        }
    }
}