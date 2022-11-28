using System;

namespace Is_it_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsDigit("3"));
        }
    }
}
//Is it a number
//    Given a string s, write a method (function) that will return true if its a valid single integer or floating number or false if its not.

//Valid examples, should return true:

//isDigit("3")
//isDigit("  3  ")
//isDigit("-3.23")
//should return false:

//isDigit("3-4")
//isDigit("  3   5")
//isDigit("3 5")
//isDigit("zero")