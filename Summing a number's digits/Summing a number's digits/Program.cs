using System.ComponentModel;

namespace Summing_a_number_s_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.SumDigits(10));
            Console.WriteLine(Kata.SumDigits(99));
            Console.WriteLine(Kata.SumDigits(-32));
            Console.WriteLine(Kata.SumDigits(102));
        }
    }
}

//Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits.

//For example: (Input-- > Output)

//10-- > 1
//99-- > 18
//- 32-- > 5
//Let 's assume that all numbers in the input will be integer values.
