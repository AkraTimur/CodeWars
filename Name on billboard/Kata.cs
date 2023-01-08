namespace Name_on_billboard
{
    internal class Kata
    {
        public static double Billboard(string name, double price = 30)
        {
            
            return (double)decimal.Multiply((decimal)name.Length, (decimal)price);
        }
    }
}
//name.Sum(x => price);
