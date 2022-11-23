using System.Text.RegularExpressions;

namespace RegexpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regexp Basics - is it a digit?");
            Console.WriteLine(Kata.Digit("fg3"));
        }
    }
}
//Regexp Basics - is it a digit?
//Implement String#digit? (in Java StringUtils.isDigit(String)), which should return true if given object is a digit (0-9), false otherwise.
