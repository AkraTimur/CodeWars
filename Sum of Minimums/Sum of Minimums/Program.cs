﻿namespace Sum_of_Minimums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.SumOfMinimums(new int[3, 5] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 20, 21, 34, 56, 100 } }));
        }
    }
}
