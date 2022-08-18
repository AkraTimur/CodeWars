using System;
using System.Collections.Generic;
using System.Text;


namespace CodeWars
{
    public class Kata
    {
        /// <summary>
        /// Exclamation marks series #1: Remove an exclamation mark from the end of string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Remove(string s)
        {
            int i = s.Length - 1;
            char[] chars = s.ToCharArray();
            if (chars[i] == '!')
                chars[i] = '|';

            string answer = new string(chars);
            return answer.Replace("|", "");
        }
        /// <summary>
        /// Determine offspring sex based on genes XX and XY chromosomes
        /// </summary>
        /// <param name="sperm"></param>
        /// <returns></returns>
        public static string ChromosomeCheck(string sperm)
        {
            if (sperm[1] == 'Y')
                return "Congratulations! You're going to have a son.";
            else return "Congratulations! You're going to have a daughter.";

            /*The male gametes or sperm cells in humans and other mammals are heterogametic and contain one of two types of sex chromosomes. They are either X or Y. The female gametes or eggs however, contain only the X sex chromosome and are homogametic.

        The sperm cell determines the sex of an individual in this case. If a sperm cell containing an X chromosome fertilizes an egg, the resulting zygote will be XX or female. If the sperm cell contains a Y chromosome, then the resulting zygote will be XY or male.

        Determine if the sex of the offspring will be male or female based on the X or Y chromosome present in the male's sperm.

        If the sperm contains the X chromosome, return "Congratulations! You're going to have a daughter."; If the sperm contains the Y chromosome, return "Congratulations! You're going to have a son.";
            */
        }
        /// <summary>
        /// String cleaning
        /// </summary>
        /// <param name="dirtyString"></param>
        /// <returns></returns>
        public static string StringClean(string dirtyString)
        {
            HashSet<char> removeChars = new HashSet<char>("1234567890");
            StringBuilder result = new StringBuilder(dirtyString.Length);
            foreach (char c in dirtyString)
                if (!removeChars.Contains(c)) // prevent dirty chars
                    result.Append(c);
            return result.ToString();
        }
        /// <summary>
        /// Count by X
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] CountBy(int x, int n)
        {
            int count = 1;
            int[] z = new int[n];
            for(int i = 0; i < z.Length; i++)
            {
                z[i] = count * x;
                count++;
            }
            return z;
        }
    }
}
