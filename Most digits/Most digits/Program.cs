﻿using System;

namespace Most_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FindLongest(new int[] { 1, 10, 100 }));  
        }
    }
}
//Most digits
//    Find the number with the most digits.

//If two numbers in the argument array have the same number of digits, return the first one in the array.