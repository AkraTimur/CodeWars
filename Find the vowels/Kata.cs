namespace Find_the_vowels
{
    public class Kata
    {
        public static int[] VowelIndices(string word)
        {
            var indices = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                word = word.ToLower();
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || 
                    word[i] == 'o' || word[i] == 'u' || word[i] == 'y')
                {
                    indices.Add(i+1);
                }
            }
            return indices.ToArray();
        }
    }
}
//return Regex.Matches(word, "(?i)[aeiouy]").Select(m => m.Index + 1).ToArray();