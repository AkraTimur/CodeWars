using System;
using System.Collections.Generic;

namespace MultipleOfIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 22, -6, 32, 82, 9, 25 };
            List <int> newList = Kata.MultipleOfIndex(list);
            Print.PrintList(newList);
            Console.ReadKey();
        }
    }
}
