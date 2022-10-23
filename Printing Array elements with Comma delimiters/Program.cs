using System;

namespace Printing_Array_elements_with_Comma_delimiters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.PrintArray(new object[] { "hello,this,is,an,array!,a,b,c,d,e!" }));
        }
    }
}