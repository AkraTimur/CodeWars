namespace Find_the_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Remainder(13, 72));
            Console.WriteLine(Kata.Remainder(0, 1));
        }
    }
}
//Task:
//Write a function that accepts two integers and returns the remainder of dividing the larger value by the smaller value.

//Divison by zero should throw a DivideByZeroException.