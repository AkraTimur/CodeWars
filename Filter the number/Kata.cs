using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Filter_the_number
{
    public class Kata
    {
        public static int FilterString(string s)
        {
            var list = new List<char>(); 
            var arr = s.ToCharArray();

            foreach (char item in arr)
            {
                if (char.IsDigit(item)) 
                    list.Add(item);
            }
            var res = string.Join("",list);
            return  int.Parse(res);           
        }
    }
}
