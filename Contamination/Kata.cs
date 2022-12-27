namespace Contamination
{
    public class Kata
    {
        public static string Contamination(string text, string character)
        {
            string res = "";
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(character))
            {
                return "";
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    res += character;
                }
                return res;
            }
        }
    }
}
// => string.Concat(Enumerable.Repeat(character, text.Length));
