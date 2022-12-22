using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIfFunction
{
    internal class Kata
    {
        public static void If(bool condition, Action func1, Action func2)
        {
            if (condition)
            {
                func1();
            }
            else func2();
        }
    }
}
