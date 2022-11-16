using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleighAuthentication
{
    public class Sleigh
    {
        public static bool Authenticate(string name, string password) => 
            name.Contains("Santa Claus") && password.Contains("Ho Ho Ho!");
    }
}
