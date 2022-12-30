using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternate_capitalization
{
    public class Kata
    {
        public static string[] Capitalize(string s)
        {
            var list = new List<string>();
            var array1 = s.ToCharArray();
            var array2 = s.ToUpper().ToCharArray();

            for (int i = 0; i < array1.Length; i+=2)
            {
                array1[i] = char.ToUpper(array1[i]);
            }
            var res = new string(array1);

            for (int i = 0; i < array2.Length; i += 2)
            {
                array2[i] = char.ToLower(array2[i]);
            }
            var res2 = new string(array2);
            list.Add(res);
            list.Add(res2);

            return list.ToArray();
        }
    }
}
