namespace Categorize_New_Member.Classes
{

    public class Kata
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            var strings = new List<string>();

            foreach (var item in data)
            {
               var age = item[0];


                var handicap = item[1];
                if (handicap > -2 && handicap < 26)
                {
                    handicap = age - handicap;
                }
                else
                {
                    handicap = 0;
                }

               var status = "";

               if (age >= 55 && handicap > 7)
               {
                    status = "Senior";
               }
               else
               {
                   status = "Open";
               }

                strings.Add(status);
            }

            return strings;
        }
    }
}