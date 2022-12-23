using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    public class JohnMeeting
    {
        public static string Meeting(string s)
        {

            var str = s.ToUpper()
                       .Replace(":", ", ")
                       .Split(';')
                       //.OrderBy(x => $"({x})")
                       .Select(x => $"({x})")
                       .ToList();
            

            return string.Join("", str);
        }
    }
}
