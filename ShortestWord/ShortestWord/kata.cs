using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestWord
{
    public class Kata
    {
        public static int FindShort(string s)
        {

            //string[] array = s.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            
            string min = s.Split().OrderBy(s => s.Length).FirstOrDefault();
            return min.Length;
        }
    }
}
// or return s.Split(' ').Min(x => x.Length);

