using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAnchor
{
    internal class Kata
    {
        public static string RemoveUrlAnchor(string url)
        {
            
            string newUrl = "";
            foreach (var item in url)
            {
                if (item != '#') newUrl = newUrl + item;
                else break;
            }
           return newUrl;
            

        }
    }
}
