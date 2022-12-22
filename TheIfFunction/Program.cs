namespace TheIfFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
//The 'if' function
//Create a function called _if which takes 3 arguments: a boolean value bool and 2 functions (which do not take any parameters): func1 and func2

//When bool is truth-ish, func1 should be called, otherwise call the func2.

//Example:
//Kata.If(true, () => Console.WriteLine("True"), () => Console.WriteLine("False"));
//// write "True" to console