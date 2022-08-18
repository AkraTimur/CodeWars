using System;

namespace PredictYourAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Predicter.PredictAge(65, 60, 75, 55, 60, 63, 64, 45));
            Console.ReadKey();
        }
    }
}
