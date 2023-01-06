namespace Printing_Array_elements_with_Comma_delimiters
{
    public class Kata
    {
        public static string PrintArray(object[] array)
        {
            return string.Join(",", array.Select(o => o is object[]? PrintArray(o as object[]) : o));
        }
    }
}
