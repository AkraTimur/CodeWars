using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_Detection
{
    public class Kata
    {
        public static bool IsAnagram(string s1, string s2)
        {
            // convert to lower case
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            // Convert the string into a char array and sort it
            char[] s1Arr = s1.ToCharArray();
            Array.Sort(s1Arr);
            char[] s2Arr = s2.ToCharArray();
            Array.Sort(s2Arr);
            // Compare the sorted arrays
            return s1Arr.SequenceEqual(s2Arr);
        }
    }
}
