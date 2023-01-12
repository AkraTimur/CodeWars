namespace Largest_pair_sum_in_array
{
    public class Kata
    {
        public static int LargestPairSum(int[] numbers)
        {
            var resList = new List<int>();
            int res = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                res = 0;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    res = numbers[i] + numbers[j];
                    resList.Add(res);
                }
            }
            return resList.Max();
        }
    }
}
//numbers.OrderByDescending(x=>x).Take(2).Sum();