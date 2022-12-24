using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcheroo
{
    internal class Kata
    {
        public static string Switcheroo(string x)
        {
           var array = x.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 'a')
                {
                    array[i] = 'b';

                }
               else if (array[i] == 'b') array[i] = 'a';
            }
            return string.Join("", array);
        }
    }
}
