using System.Text;

namespace Compare_2_digit_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Compare(29, 92));
            Console.WriteLine(Compare(10, 11));
            Console.WriteLine(Compare(33, 33));
            Console.WriteLine(Compare(45, 45));
            Console.WriteLine(Compare(29, 92));
            Console.WriteLine(Compare(14, 24));
            Console.WriteLine(Compare(56, 57));
            Console.WriteLine(Compare(10, 22));
            Console.WriteLine(Compare(11, 44));
            Console.WriteLine(Compare(98, 70));
            Console.WriteLine(Compare(66, 16));
            Console.WriteLine(Compare(98, 88));
            Console.WriteLine(Compare(78, 58));
            Console.WriteLine(Compare(47, 56));
        }

        public static string Compare(int a, int b)
        {
            // Разделение чисел на цифры
            int a1 = a / 10, a2 = a % 10;
            int b1 = b / 10, b2 = b % 10;

            // Сравнение цифр
            if ((a1 == b1 && a2 == b2) || (a1 == b2 && a2 == b1))
            {
                return "100%";
            }
            else if (a1 == b1 || a2 == b2 || a1 == b2 || a2 == b1)
            {
                return "50%";
            }
            else
            {
                return "0%";
            }
        }
    }
}