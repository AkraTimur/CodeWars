namespace Count_consonants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConsonantCount("h^$&^#$&^elLo world"));
        }
        public static int ConsonantCount(string str)
        {
            str = str.ToLower();
            int count = 0;
            foreach (char item in str) 
            {
                if (item == 'a' || item == 'e' || item == 'i' ||
                    item == 'o' || item == 'u')
                {
                    continue;
                }
                else if (char.IsNumber(item) || (char.IsDigit(item) || (char.IsControl(item) || !char.IsLetter(item))))
                {
                    continue;
                }
                else count++;
            }
            return count;
        }
    }
}
// return Regex.Matches(str.ToLower(), "[b-df-hj-np-tv-z]").Count;