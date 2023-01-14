using System.Text;

namespace Jaden_Casing_Strings
{
    public class Kata
    {
        public static string ToJadenCase(string phrase)
        {
            var sb = new StringBuilder();
            var arr = phrase.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                var firsChar = arr[i].ToCharArray();
                var temp = char.ToUpper(firsChar[0]);
                firsChar[0] = temp;
                sb.Append(firsChar);
                if(i != arr.Length-1) sb.Append(' ');
            }
            return sb.ToString();
        }
    }
}
//return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));