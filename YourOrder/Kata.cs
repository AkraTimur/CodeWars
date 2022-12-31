using System.Reflection.Metadata.Ecma335;

namespace YourOrder
{
    public static  class Kata 
    {
        static public string pos1 = "";
        static public string pos2 = "";
        static public string pos3 = "";
        static public string pos4 = "";
        static public string pos5 = "";
        static public string pos6 = "";
        static public string pos7 = "";
        static public string pos8 = "";
        static public string pos9 = "";

        public static string Order(string words)
        {
            if (words == "") return "";
            var str = words
                      .Split(" ")
                      .ToList();

            foreach (var item in str)
            {
                if (item.Contains('1') && (item.Length > 1)) pos1 = item;
                if (item.Contains('2')&& (item.Length > 1)) pos2 = item;
                if (item.Contains('3')&& (item.Length > 1)) pos3 = item;
                if (item.Contains('4')&& (item.Length > 1)) pos4 = item;
                if (item.Contains('5') && (item.Length > 1)) pos5 = item;
                if (item.Contains('6') && (item.Length > 1)) pos6 = item;
                if (item.Contains('7')&& (item.Length > 1)) pos7 = item;
                if (item.Contains('8')&& (item.Length > 1)) pos8 = item;
                if (item.Contains('9') && (item.Length > 1)) pos9 = item;
            }

            ////для дублирования
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(@"{pos{i}\}\\");
            //}
            
            return $"{pos1} {pos2} {pos3} {pos4} {pos5} {pos6} {pos7} {pos8} {pos9}".Trim();
        }

    }
}
//https://www.codewars.com/kata/55c45be3b2079eccff00010f/train/csharp
