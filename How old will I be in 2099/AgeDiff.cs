namespace How_old_will_I_be_in_2099
{
    public class AgeDiff
    {
        public static string CalculateAge(int birth, int yearTo)
        {
            var res = yearTo - birth;

            if (birth == yearTo) return "You were born this very year!";

            else if (res == 1) return $"You are {res} year old.";

            else if (res > 1) return $"You are {res} years old.";

            else if (res == -1) return $"You will be born in {res * -1} year.";


            return $"You will be born in {res * -1} years."; 

        }
    }
}
