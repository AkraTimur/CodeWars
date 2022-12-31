using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEveryDigit
{
    internal class Kata
    {
        public static int SquareDigits(int n)
        {
            var str = n.ToString();
            var array = str.ToCharArray();
            var list = new List<string>();
            
            foreach (var item in array)
            {
                list.Add((int.Parse(item.ToString()) * int.Parse(item.ToString())).ToString());

            }    
            var res = string.Join("", list);
            int.TryParse(res, System.Globalization.NumberStyles.AllowThousands, null, out int result);
            return result;
        }
    }
}
