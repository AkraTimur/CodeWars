namespace Highest_Scoring_Word
{

    public class HightWord
    {
        public  string WordName { get; set; }
        public  int WordValue { get; set; }

        public  HightWord(string name, int count) 
        {
            this. WordName= name;
            this.WordValue = count;    
        }

    }
    public class Kata
    {
        public static string High(string s)
        {
            var list = new List<HightWord>();
            int count = 0;
            var arr = s.Trim()
                .Split();
            foreach (var word in arr)
            {
                count = 0;
                foreach (var item in word)
                {
                    count = count + (item % 32);
                }
                list.Add(new HightWord(word, count));
            }

            return list.OrderByDescending(x => x.WordValue).Select(x => x.WordName).First(); 
        }
    }
}
//s.Split(' ').OrderByDescending(x => x.Sum(z => z - 'a' + 1)).First();
