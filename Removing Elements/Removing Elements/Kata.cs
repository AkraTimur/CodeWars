namespace Removing_Elements
{
    public class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            var list = new List<object>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    list.Add(arr[i]);
                }
                else  if (i % 2 == 0)
                {
                    list.Add(arr[i]);
                }
            }
            return list.ToArray();
        }
    }
}
// return arr.Where((e, i) => i%2 == 0).ToArray();
