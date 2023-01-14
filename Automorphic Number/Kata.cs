namespace Automorphic_Number
{
    public class Kata
    {
        public static string Automorphic(int n)
        {
            int square = n * n;
            if ($"{square}".EndsWith($"{n}")) return "Automorphic";
            return "Not!!";
        }
    }
}
//Вычислите квадрат числа.

//Преобразуйте квадрат числа в строку.

//Ищите строку с исходным числом в квадратном числе.

//Если строка найдена, число является автоморфным, иначе нет.