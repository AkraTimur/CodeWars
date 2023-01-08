namespace Check_the_exam
{
    public class Kata
    {
        public static int CheckExam(string[] arr1, string[] arr2)
        {
            int count = 0;
            int i = 0;

            foreach (var item1 in arr1)
            {
                for (; i < arr2.Length;)
                {
                    if (item1 == arr2[i]) count += 4;
                    else if (item1 != arr2[i] && arr2[i] != "") count -= 1;
                    else count += 0;
                    break;
                }
                i++;
            }
            if (count < 0) return 0;
            return count;
        }
    }
}
