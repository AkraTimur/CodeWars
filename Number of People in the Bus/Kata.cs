using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_People_in_the_Bus
{
    internal class Kata
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int result = 0;
            foreach (var item in peopleListInOut)
            {
               result += item[0];
                result -= item[1];
            }
            return result;

        }
        
    }
}
