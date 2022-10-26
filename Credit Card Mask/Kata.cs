using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Card_Mask
{
    public static class Kata
    {
        public static string Maskify(string cc)
        {
            if (cc.Length >= 4)
            {
                var c = cc.ToCharArray();
                var symbol = '#';
                for (int i = 0; i < cc.Length - 4; i++)
                {
                    c[i] = symbol;
                }
                return new string(c);
            }else
                return cc;

        }
    }
}
