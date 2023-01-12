using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    public class Kata
    {
        public static int Pillars(int numPill, int dist, int width)
        {
            if (numPill == 1) return 0;

            else if (numPill <= 2)
            {
                return  dist * 100;
            }
            else
            {
                width = (numPill - 2) * width;

                return dist * (numPill-1) * 100 + width;

            }
        }
    }
}
