namespace CSPS.Problems
{
    internal class _1431 : IProblem
    {
        public string Result
        {
            get
            {
                int[] candies = [2, 3, 5, 1, 3];
                int extraCandies = 3;
                return string.Join(", ", new _1431().KidsWithCandies(candies, extraCandies));
            }
        }
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = 0;
            bool[] result = new bool[candies.Length];

            for (int i=0; i < candies.Length; i++)
            {
                if (candies[i] > max)
                {
                    max = candies[i];
                }
            }

            for (int i=0; i < candies.Length; i++)
            {
                result[i] = candies[i] + extraCandies >= max;
            }

            return result;
        }
    }
}
