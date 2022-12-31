namespace GreetMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greet("riley"));
        }
        public static string Greet(string name)
        {
           var newName = name.ToLower().ToArray();

            newName[0] = char.ToUpper(name[0]);

            return $"Hello {new string(newName)}!";  
        }
    }
}
//Greet Me
//    Write a method that takes one argument as name and then greets that name, capitalized and ends with an exclamation point.

//Example:

//"riley"-- > "Hello Riley!"
//"JACK"-- > "Hello Jack!"
