namespace Remove_All_The_Marked_Elements_of_a_List
{
    internal class Program
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            var list = integerList.ToList();
            list.RemoveAll(number => valuesList.Contains(number));
            return list.ToArray();
        }

        static void Main(string[] args)
        {
            var arr1 = new int[] { 1, 1, 2, 3, 1, 2, 3, 4 };
            var arr2 = new int[] { 1, 3 };

            var res = Remove(arr1, arr2);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}