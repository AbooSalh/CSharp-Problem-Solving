namespace CSPS.Problems
{
    internal class RomanToInt
    {
        public string Result
        {
            get
            {
                string s = "IV";
                return Solve(s).ToString();
            }
        }
        public static int Solve(string s)
        {
            int result = 0;
            Dictionary<char, int> romanMap = new()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            for (int i = 0; i < s.Length; i++)
            {
                int currentValue = romanMap[s[i]];
                if (i + 1 < s.Length && currentValue < romanMap[s[i + 1]])
                {
                    result -= currentValue;
                }
                else
                {
                    result += currentValue;
                }
            }
            return result;
        }
    }
}
