namespace Check_the_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.CheckExam(new string[] { "a", "a", "c", "b" }, new string[] { "a", "a", "b", "" }));
        }
    }
}