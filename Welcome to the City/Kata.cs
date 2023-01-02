using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_to_the_City
{
    public class Kata
    {
        public static string SayHello(string[] name, string city, string state)
        {
            return $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
        }
    }
}
