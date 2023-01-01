using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_an_array_of_strings_to_array_of_numbers
{
    public class stringArrayMethods
    {
        public static double[] ToDoubleArray(string[] stringArray)
        {
            var list = new List<double>();
            foreach (var item in stringArray) 
            {
                list.Add(double.Parse(item,CultureInfo.InvariantCulture.NumberFormat));
            }
            return list.ToArray();
        }
    }
}
