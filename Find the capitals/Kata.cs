namespace Find_the_capitals
{
    public class Kata
    {
        public static int[] Capitals(string word)
        {
            var array = word.ToCharArray();

            var list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsUpper(array[i]))
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }
    }
}
