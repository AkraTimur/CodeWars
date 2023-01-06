namespace Sort_array_by_string_length
{
    public class Kata
    {
        public static string[] SortByLength(string[] array)
        {
            return array.OrderBy(x => x.Length).ToArray();
        }
    }
}
