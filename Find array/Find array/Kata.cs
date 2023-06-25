namespace Find_array_cs
{
    public class Kata
    {
        public static object[] FindArray(object[] arr1, int[] arr2)
        {
            var list = new List<object>();
            var exitList = new List<object>();

            if (arr1.Length <= 0 || arr2.Length <= 0) return exitList.ToArray();

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] > arr1.Length) return exitList.ToArray();

                var obj = arr1[arr2[i]];
                list.Add(obj);
            }

            return list.ToArray();
        }
    }
}
