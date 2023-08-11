using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Office_II___Boredom_Score
{
    public class Kata
    {
        public enum Departments
        {
            accounts = 1,
            finance = 2,
            canteen = 10,
            regulation = 3,
            trading = 6,
            change = 6,
            IS = 8,
            retail = 5,
            cleaning = 4,
            pissingabout = 25
        }

        public static string Boredom(Dictionary<string, string> staff)
        {
            var listOfRes = new List<int>();
            foreach (var item in staff)
            {
                if(Enum.TryParse<Departments>(item.Value.Replace(" ", ""), out var enumValue))
                {
                    int intValue = (int)enumValue;
                    listOfRes.Add(intValue);
                }
            }

            var sum = listOfRes.Sum();

            switch (sum)
            {
                case int n when n <= 80:
                    return "kill me now";

                case int n when n> 80 && n < 100:
                    return "i can handle this";

                default: return "party time!!";
            }
        }
    }
}