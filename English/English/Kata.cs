using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    public class Kata
    {
        public static bool SpeakEnglish(string sentence)
        {
            // Good luck!;
            return sentence.ToLower().Contains("english");
        }
    }
}
