namespace Sum_of_odd_numbers
{
    public class Kata
    {
        public static long RowSumOddNumbers(long n)
        {
            // The first number of the nth row is equal to (n^2) - (n-1)
            long first = (n * n) - (n - 1);
            // The last number of the nth row is equal to (n^2) + (n-1)
            long last = (n * n) + (n - 1);
            // The sum of the numbers in the nth row is equal to (first + last) * n / 2
            return (first + last) * n / 2;
        }
    }
}
