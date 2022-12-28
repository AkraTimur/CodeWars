using System.Numerics;

namespace Powers_of_2
{
    public class Kata
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            var list = new List<BigInteger>();
            if (n == 0)
            {
                list.Add((uint)1);
                return list.ToArray();
            }
            else
            {
                for (int i = 0; i < n + 1; i++)
                {
                    if (i == 0) list.Add(1);

                    else list.Add(BigInteger.Pow(2, i));

                }
            return list.ToArray();
            }
        }
    }
}
