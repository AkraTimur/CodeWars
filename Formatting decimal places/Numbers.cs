using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting_decimal_places
{
    internal class Numbers
    {
        public static double TwoDecimalPlaces(double number) => Math.Round(number, 2, MidpointRounding.AwayFromZero);
    }
}
