using System.Linq;

namespace last_digits_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = LastDigit(1343, 5);
            foreach (var digit in res)
            {
                Console.WriteLine(digit);
            }
        }

        public static int[] LastDigit(long n, int d)
        {
            var strN = n.ToString();

            var list = new List<int>();

            if (d <= 0)
            {
                return list.ToArray();
            }

            for (int i = 0; i < strN.Length; i++) 
            {
                list.Add(int.Parse(strN[i].ToString()));
            }

            var listOfRes = new List<int>();

            if (d > list.Count) d = 0;
            else  d = list.Count - d;

            for (int j  = d; j < list.Count; j++)
            {
                listOfRes.Add(list[j]);
            }
        
            return listOfRes.ToArray();
        }
    }
}
//Your job is to implement a function which returns the last D digits of an integer N as a list.