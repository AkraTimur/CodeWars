namespace Is_n_divisible_by
{
    public static class KataChallenge
    {
        public static bool IsDivisible(params int[] divisors)
        {
            int dividend = divisors[0];
            bool answer = true; // Изначально считаем, что все деления прошли

            if (divisors.Length == 0)
            {
                return true; // Если нет дополнительных делителей, то всегда возвращаем true
            }

            for (int i = 0; i < divisors.Length; i++)
            {
                if (divisors[i] == 0)
                {
                    return false; // Деление на ноль не допускается
                }

                if (dividend % divisors[i] != 0)
                {
                    answer = false; // Если хотя бы одно деление не прошло, меняем флаг на false
                }
            }

            return answer;
        }
    }
}
