using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeodorantEvaporator
{
    public class Evaporator
    {
        public static int evaporator(double content, double evap_per_day, double threshold)
        {
            var result = 0;
            double percentage = 100;
            while (percentage > threshold)
            {
                percentage = percentage - percentage * (evap_per_day / 100);
                result += 1;
            }
            return result;
        }
    }
}
