namespace Sums_of_a_lot_of_numbers
{
    public class Kata
    {
        public static long? RangeSum(long n)
        {
            if(n == 0 || n < 0) return null;

            return n * (n + 1)/2;
        }
    }
}
