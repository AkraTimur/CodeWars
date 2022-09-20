using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleOfIndex
{
    internal class Kata
    {
        public static List<int> MultipleOfIndex(List<int> xs)
        {
            List<int> s = new List<int>();
            foreach (int element in xs)
            {
                var index = xs.IndexOf(element);
               
                if ((index != 0) && (element % index == 0))
                {
                    s.Add(element);
                }
            }
            return s;
        }

    }
}
