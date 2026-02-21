namespace CSPS.Problems
{
    internal class Evaluate_Reverse_Polish_Notation : IProblem

    {
        public string Result
        {
            get
            {
                string[] tokens = ["2", "1", "+", "3", "*"];
                int result = EvalRPN(tokens);
                return result.ToString();
            }
        }
        public static int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var token in tokens)
            {
                if (int.TryParse(token, out int num))
                {
                    stack.Push(num);
                }
                else
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    switch (token)
                    {
                        case "+":
                            stack.Push(a + b);
                            break;
                        case "-":
                            stack.Push(a - b);
                            break;
                        case "*":
                            stack.Push(a * b);
                            break;
                        case "/":
                            stack.Push(a / b);
                            break;
                    }
                }
            }
            return stack.Pop();
        }
    }
}
