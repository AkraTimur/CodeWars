using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_position
{
    public class Kata
    {
        public static string Position(char alphabet)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int alphaNum = 0;
            for (int i = 0; i < alpha.Length; i++)
            {
                if (char.ToLower(alpha[i]) == char.ToLower(alphabet)) alphaNum = i;
            }

            return $"Position of alphabet: {alphaNum + 1}";
        }
    }
}
//$"Position of alphabet: {alphabet - 96}";
