namespace Sorted
{
    internal class Kata
    {
        
        public static string IsSortedAndHow(int[] array)
        {
            var list = array.ToList();
            var list2 = list.OrderBy(x => x).ToList();
            var list3 = list.OrderByDescending(x => x).ToList();

            if (list.SequenceEqual(list2))
            {
                return "yes, ascending";
            }
            else if (list.SequenceEqual(list3)) return "yes, descending";
            
            return "no";
        }
    }
}
