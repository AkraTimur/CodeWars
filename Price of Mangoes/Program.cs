namespace Price_of_Mangoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mango(3,3));
        }
        public static int Mango(int quantity, int price)
        {
            return quantity * price - (quantity / 3 * price);
        }
    }
}