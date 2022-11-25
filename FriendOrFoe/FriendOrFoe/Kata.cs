using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrFoe
{
    public class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            // Good luck!
            var resList = new List<string>();
            foreach (var name in names)
            {
                if(name.Length == 4) 
                    resList.Add(name); 
            }
            return resList.AsEnumerable();
        }
    }
}

// return names.Where(name => name.Length == 4);