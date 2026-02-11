namespace CSPS.Problems
{
    
    internal class IsPalindrome : IProblem

    {
        public string Result
        {
            get
            {
                int s = 121;
                return Solve(s).ToString();
            }
        }
        public static bool Solve(int x)
        {
            if (x < 0) return false;
            int original = x;
            int reversed = 0;
            while (x > 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;
            }
            return original == reversed;
        }
    }
}
