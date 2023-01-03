namespace Are_arrow_functions_odd
{
    public class Kata
    {
        public static List<int> Odds(List<int> values) =>
            values.Where(x => x % 2 == 1)
                  .ToList();
    }
}
