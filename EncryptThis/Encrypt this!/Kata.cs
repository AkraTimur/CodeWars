using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_this_
{
    public class Kata
    {
        public static string EncryptThis(string input)
        {
            var list = new List<string>();
            var code = 0;
            var str = input.Split();

            foreach (var item in str)
            {
                if (item.Length > 1)
                {
                    code = (int)item[0];
                    var charLast = (char)item[item.Length - 1];
                    var charSecond = (char)item[1];
                    var strRes = item.ToString().Remove(0, 2);

                    if (strRes.Length == 1)
                    {
                        strRes = strRes.Replace($"{strRes}", "");
                        var strFinall = $"{code}{charLast}{strRes}{charSecond}";
                        list.Add(strFinall);
                    }
                    else if (strRes.Length < 1)
                    {
                        var strFinall = $"{code}{charLast}{strRes}";
                        list.Add(strFinall);
                    }
                    else
                    {
                        strRes = strRes.Remove(strRes.Length - 1);
                        var strFinall = $"{code}{charLast}{strRes}{charSecond}";
                        list.Add(strFinall);
                    }

                }
                else if (item.Length == 1)
                {
                    code = (int)item[0];
                    var strRes2 = item.ToString().Replace($"{item}", $"{code}");
                    list.Add(strRes2);
                }
                
            }
            return string.Join(" ", list);
        }
    }
}
