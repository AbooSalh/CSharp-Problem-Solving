namespace CSPS.Problems
{
    internal class MaxConsecutiveOnes : IProblem

    {
        public string Result
        {
            get
            {
                int[] nums = new int[] { 1, 1, 0, 1, 1, 1 };
                return FindMaxConsecutiveOnes(nums).ToString();
            }
        }
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    current++;
                }
                else
                {
                    max = Math.Max(max, current);
                    current = 0;
                }

            }
            return Math.Max(max, current);
        }
    }
}
