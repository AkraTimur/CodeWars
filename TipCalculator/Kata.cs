using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    public class Kata
    {
        public static int CalculateTip(double amount, string rating)
        {
            switch (rating.ToLower())
            {
                case "terrible": return 0;
                case "poor": return Convert.ToInt32(Math.Ceiling(amount * 0.05));
                case "good": return Convert.ToInt32(Math.Ceiling(amount * 0.10));
                case "great": return Convert.ToInt32(Math.Ceiling(amount * 0.15));
                case "excellent": return Convert.ToInt32(Math.Ceiling(amount * 0.20));
                default:return -1;
            }
        }
    }
}
