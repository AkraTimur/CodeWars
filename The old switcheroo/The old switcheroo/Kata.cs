using System.Text.RegularExpressions;

namespace The_old_switcheroo
{
    public class Kata
    {
        public static string Vowel2Index(string str)
        {
            return Regex.Replace(str, "[aeiou]", x => (x.Index + 1).ToString());
            var arr = str.ToCharArray();
            string vowels = "aeiou";
            var list = new List<string>(); 


            for (int i = 0; i < arr.Length; i++)
            {
                var index = i + 1;

                if (vowels.Contains(arr[i]))
                {
                    list.Add(index.ToString());
                }
                else
                {
                    list.Add(arr[i].ToString());
                }
            }

            return string.Join("", list.ToArray());
        }
    }
}
//return  Regex.Replace(str, "[aeiou]", x => (x.Index + 1).ToString());