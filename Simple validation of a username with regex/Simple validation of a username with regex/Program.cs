using System;

namespace Simple_validation_of_a_username_with_regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.ValidateUsr("asddsa"));
        }
    }
}

//Simple validation of a username with regex

//    Write a simple regex to validate a username. Allowed characters are:

//lowercase letters,
//numbers,
//underscore
//Length should be between 4 and 16 characters (both included).
//https://www.codewars.com/kata/56a3f08aa9a6cc9b75000023/train/csharp