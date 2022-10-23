using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Remove_First_and_Last_Character_Part_Two
{
    public  class Kata
    {
        public static string Array(string? s)
        {
            
            if ((s==null) || (s.Length<=2))
            {
#pragma warning disable CS8603 // Possible null reference return.
                return null;
#pragma warning restore CS8603 // Possible null reference return.
            }
            else
            {
                return  s.Remove(0, 0 + 1)
                       .Remove(s.Length - 2)
                       .Replace(",", " ");
            }
            
            
        }
    }
}
//string mystr = s.Remove(0, 0 + 1);
//string mystr1 = s.Remove(s.Length - 1);
//return mystr1;