using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_oddities_here
{
    public class NoOddities
    {
        public static int[] NoOdds(int[] values)
        {
            List<int> result = new List<int>();
            foreach (var item in values)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
            ///  return values.Where(x => x % 2 == 0).ToArray();
        }
    }
}
