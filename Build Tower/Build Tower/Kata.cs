using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_Tower
{
    public class Kata
    {
        public static string[] TowerBuilder(int nFloors)
        {
            var result = new string[nFloors];

            // этажи
            for (int i = 0; i < nFloors; i++)
            {
                result[i] = string.Concat(new string(' ', nFloors - i - 1),
                                new string('*', i * 2 + 1),
                                new string(' ', nFloors - i - 1));
            }
            return result;
        }
    }
}
