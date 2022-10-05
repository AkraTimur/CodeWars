using System;
namespace RemoveAnchor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Kata.RemoveUrlAnchor("www.codewars.com#about"));
            Console.WriteLine(Kata.RemoveUrlAnchor("www.codewars.com?page=1"));
        }
    }
}