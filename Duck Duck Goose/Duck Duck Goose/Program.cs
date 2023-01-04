namespace Duck_Duck_Goose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exampleNames = new string[] { "a", "b", "c", "d", "c", "e", "f", "g", "h", "z" };
            var players = exampleNames.Select(x => new Player(x)).ToArray();
            
            Console.WriteLine(Kata.DuckDuckGoose(players, 12));
        }
    }
}