using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWithAlphabetPosition
{
    public class Kata
    {
        public static string AlphabetPosition(string text)
        {
            var str = text.Replace(" ", "").ToCharArray();
            var index = 0;
            var list = new List<string>();

            foreach (var item in str)
            {
                if (char.IsLetter(item) && (!char.IsNumber(item)))
                {
                    index = char.ToUpper(item) - 64; 
                    list.Add(index.ToString());
                }
            }

            return string.Join(" ", list);
        }
    }
}
//return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
