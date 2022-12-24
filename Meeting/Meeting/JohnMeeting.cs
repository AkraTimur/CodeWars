using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    public class JohnMeeting
    {
        public string Name { get; set; }

        public string FirstName { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public JohnMeeting(string name, string firstName) 
        {
            this.Name = name;
            this.FirstName = firstName;
        }
        public static string Meeting(string s)
        {

            var str = s.ToUpper()
                       .Replace(":", " ")
                       .Split(';', ' ')
                       .ToList();

            var list = CreateListOfObject(str);

            var sortList = list.OrderBy(x => x.FirstName)
                               .ThenBy(x => x.Name)
                               .Select(x => $"({x.FirstName}, {x.Name})")
                               .ToList();


            return string.Join("", sortList);
        }
        public static List<JohnMeeting> CreateListOfObject(List<string> str)
        {
            var list = new List<JohnMeeting>();
            for (int i = 0; i < str.Count; i += 2)
            {
                var user = new JohnMeeting (str[i], str[i + 1]);
                list.Add(user);
            }
            return list;
        }
    }
}
//https://www.codewars.com/kata/59df2f8f08c6cec835000012/train/csharp