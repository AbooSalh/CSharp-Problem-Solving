namespace CSPS.Problems
{
    internal class SetMismatch : IProblem
    {
        public string Result
        {
            get
            {
                int[] nums = [1, 2, 2, 4];
                return string.Join(", ", FindErrorNums(nums));
            }
        }

        public int[] FindErrorNums(int[] nums)
        {
            int[] freq = new int[nums.Length + 1];
            int[] result = new int[2];

            foreach (int num in nums)
            {
                freq[num]++;
            }

            for (int i = 1; i <= nums.Length; i++)
            {
                if (freq[i] == 2)
                    result[0] = i;   // duplicate

                if (freq[i] == 0)
                    result[1] = i;   // missing
            }

            return result;
        }
    }
}
