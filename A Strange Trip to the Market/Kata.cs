using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Strange_Trip_to_the_Market
{
    internal class Kata
    {
        public static bool IsLockNessMonster(string sentence)
        {
            sentence = sentence.ToLower();
            string one = "tree fiddy";
            string two = "3.50";
            string three = "three fifty";
            if ((sentence.Contains(one)) || (sentence.Contains(two)) || (sentence.Contains(three)))
                return true;
            else return false;
        }
    }
}
