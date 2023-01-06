namespace Alphabet_symmetry
{
    public class Kata
    {
        public static List<int> Solve(List<string> arr)
        {
            int index = 0;
            int count = 0;
            var listOfres = new List<int>();
            foreach (var item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                        index++;
                        var res = item[i] % 32;
                        if (index == res ) count++;
                        
                }
                listOfres.Add(count);
                count = 0;
                index = 0;

            }
            return listOfres;
        }
    }
}
//return arr.Select(s => s.Where((c, i) => c % 32 == i + 1).Count()).ToList();
