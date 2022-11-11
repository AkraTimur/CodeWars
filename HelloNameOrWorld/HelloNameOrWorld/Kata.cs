using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloNameOrWorld
{
    
    public class Kata
    {
        public static string Hello(string name = "")
        {
            if (name == "" || name == null)
            {
                return "Hello, World!";
            }
            else
            {
                return "Hello, " + name[0].ToString().ToUpper() + name.Substring(1).ToLower() + "!";
            }
        }
    }
}
