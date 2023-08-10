namespace The_Most_Amicable_of_Numbers
{
    public class Kata
    {
        public static bool AmicableNumbers(int num1, int num2)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();

            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0)
                {
                    list1.Add(i);
                }
            }

            for (int j = 1;j <= num2; j++)
            {
                if (num2 % j == 0)
                {
                    list2.Add(j);
                }
            }

            return list1.Sum() == list2.Sum();
        }
    }
}
