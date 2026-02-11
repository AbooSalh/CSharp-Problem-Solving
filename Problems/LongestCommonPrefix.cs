namespace CSPS.Problems
{
    internal class LongestCommonPrefix
    {
        public string Result
        {
            get
            {
                string[] strs = ["flower", "flow", "flight"];
                return Solve(strs);
            }
        }
        static string Solve(string[] strs)
        {
            Array.Sort(strs);
            string s = "";
            int i = 0;
            int length = strs.Length;

            while (i < strs[0].Length)
            {
                if (strs[0][i] == strs[length - 1][i])
                    s += strs[0][i];
                else
                    break;
                i++;
            }

            return s;
        }
    }
}
