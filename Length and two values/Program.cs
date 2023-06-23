namespace Length_and_two_values_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Alternate(5, true, false));
        }

        public static object[] Alternate(int n, object firstValue, object secondValue)
        {
            var list = new List<object>();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(firstValue);
                }
                else
                {
                    list.Add(secondValue);
                }
            }   
            return list.ToArray();
        }
    }
}