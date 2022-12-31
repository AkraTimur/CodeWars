namespace YourOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Order("B1ob A2lice E3rnst G4reg J5amila 6 7 8 9"));
        }
    }
}

//Your order, please
//Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

//Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

//If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.
