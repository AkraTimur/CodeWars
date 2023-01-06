namespace Counting_Duplicates
{
    public class Kata
    {
        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(x => x).Where(x => x.Count() > 1).Count();
        }
    }
}
