namespace Reversing_Words_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static string Reverse(string input)
        {
            // Split the input string into words and reverse the array
            string[] words = input.Split(new char[] { ' ' });
            Array.Reverse(words);
            // Join the reversed words into a single string, with a single space as separator
            return string.Join(" ", words);

        }
    }
}