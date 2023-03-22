namespace Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidParentheses("()"));
        }
        public static bool ValidParentheses(string str)
        {
            var stack = new Stack<char>();

            foreach(char c in str)
            {
                if(c == '(')
                {
                    stack.Push(c);
                }

                else if (c == ')')
                {
                    if(stack.Count == 0 || stack.Peek() != '(')
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
    }
}