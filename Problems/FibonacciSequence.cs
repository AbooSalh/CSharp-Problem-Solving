using System.Xml.Linq;

namespace CSPS.Problems
{
    internal class FibonacciSequence
    {
        public string Result
        {
            get
            {
                int n = 10;
                return Solve(n).ToString();
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    Result = value;
                }
            }
        }
        static int Solve(int n)
        {
            if (n == 0 || n == 1) return n;
            return Solve(n - 1) + Solve(n - 2);
        }
    }
}
