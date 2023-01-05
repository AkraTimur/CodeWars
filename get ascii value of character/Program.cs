namespace get_ascii_value_of_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetASCII('A'));
        }
        public static int GetASCII(char c)
        {
            return (int)c;
        }
    }
}