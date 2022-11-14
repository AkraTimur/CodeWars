using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContertToCNY
{
    internal class Kata
    {
        public static string Usdcny(int usd)
        {
            return $"{(Convert.ToDecimal(usd) * 6.75M).ToString("0.00")} Chinese Yuan";
        }
    }
}
