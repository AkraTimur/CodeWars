using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class NoBoring
    {/// <summary>
     /// No zeros for heros
     /// </summary>
     /// <param name="n"></param>
     /// <returns></returns>
        public static int NoBoringZeros(int n)
        {
            while (n % 10 == 0)
            {
                n /= 10;
            }
            return n;
            /*Numbers ending with zeros are boring.
              They might be fun in your world, but not here.
              Get rid of them. Only the ending ones.
             */
        }
    }
}
