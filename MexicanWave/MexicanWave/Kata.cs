using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicanWave
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            if (str == null) return new List<string>() { };

            var resList = new List<string>();

            var arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr = str.ToCharArray();
                if (arr[i] != ' ')
                {
                    arr[i] = char.ToUpper(arr[i]);
                    resList.Add(new string(arr));
                }
                else arr[i] = ' ';
            }
            return resList;
        }
    }
}
