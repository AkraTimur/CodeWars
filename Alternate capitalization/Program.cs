using System.Runtime.Intrinsics.X86;

namespace Alternate_capitalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Capitalize("abcdef"));
        }
    }
}
// Alternate capitalization
//Given a string, capitalize the letters that occupy even indexes and odd indexes separately, and return as shown below. Index 0 will be considered even.

//For example, capitalize("abcdef") = ['AbCdEf', 'aBcDeF']. See test cases for more examples.

//The input will be a lowercase string with no spaces.