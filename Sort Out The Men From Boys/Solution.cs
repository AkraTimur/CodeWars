namespace Sort_Out_The_Men_From_Boys
{
    public class Solution
    {
        public static int[] MenFromBoys(int[] a)
        {
            var listMens = new List<int>();
            var listBoys = new List<int>();

            foreach (var item in a)
            {
                if (item % 2 == 0) listMens.Add(item);
                else listBoys.Add(item);
            }

            var list1 = listMens.Distinct().OrderBy(x => x).ToList();
            var list2 = listBoys.Distinct().OrderByDescending(x => x).ToList();
            return list1.Union(list2).ToArray();
        }
    }
}
