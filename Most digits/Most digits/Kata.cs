using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Most_digits
{
    class Kata
    {
        public static int FindLongest(int[] number)
        {
            // code here
            var list = new List<string>();

            foreach (var item in number)
            {
                list.Add(Convert.ToString(item));
            }

            var listMax = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length > listMax.Length)
                    listMax = list[i];
            }

            var res = "";
            foreach (var item in list)
            {
                if(listMax.Length == item.Length)
                {
                    res = item;
                    break;
                }
            }
            return int.Parse(res);
        }
    }
}
//return N.OrderByDescending(X => X.ToString().Length).First();