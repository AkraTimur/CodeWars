using System.Numerics;

namespace Jungerstein_s_Math_Training_Room
{
    public static class Kata
    {
        public static int CountZeros(int n)
        {
            BigInteger mult = 1;
            if (n % 2 == 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if(i % 2 == 0)
                    {
                        mult *= i;
                    }
                }
            }
            else
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j % 2 != 0)
                    {
                        mult *= j;
                    }
                }
            }

            var res = mult.ToString();
            var zeroCount = 0;
            for (int count = res.Length-1; count >= 0; count--)
            {
                if (res[count].ToString() == "0")
                {
                    zeroCount++;
                }
                else return zeroCount;

            }
            return zeroCount;
        }
    }
}