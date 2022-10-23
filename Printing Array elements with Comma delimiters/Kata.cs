using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Array_elements_with_Comma_delimiters
{
    public  class Kata
    {
        public static string PrintArray(object[] array)
        {

            return string.Join(",", array);
        }
    }
}
