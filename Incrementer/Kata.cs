namespace Incrementer
{
    public class Kata
    {
        public static int[] Incrementer(int[] numbers)
        {
            if (numbers.Length < 1) return new int[0];
            int index = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] + (index + i);
                if (numbers[i] >= 10) numbers[i] = numbers[i]%10;
            }
            return numbers; 
        }
    }
}
