using System.Text.RegularExpressions;

namespace The_old_switcheroo_2
{
    public class Kata
    {
        public static string Encode(string str)
        {
            string englishAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string pattern = "[" + englishAlphabet + "]+";

            return Regex.Replace(str, pattern, x => EncodeWord(x.Value), RegexOptions.IgnoreCase);
        }

        public static string EncodeWord(string word)
        {
            string englishAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string encoded = string.Join("",
                word.Select(c => englishAlphabet.IndexOf(char.ToLower(c)) + 1));

            return encoded;
        }
    }
}
