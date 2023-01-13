namespace Sort_Out_The_Men_From_Boys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Solution.MenFromBoys(new int[] { 7, 3, 14, 17 });

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}