using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altERnaTIngCaSe
{
    public static class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            var array = s.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsUpper(array[i]))
                {
                    array[i] = char.ToLower(array[i]);
                }
                else if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
            return new string(array);
        }
    }
}
//return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
