using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_Turnover
{
    internal class Kata
    {
        public static string Apple(object n)
        {
          int a = int.Parse(n.ToString());
            var squad = a * a;
            if (squad > 1000)
            {
                return "It's hotter than the sun!!";
            }
            else return "Help yourself to a honeycomb Yorkie for the glovebox.";
        }
    }
}
