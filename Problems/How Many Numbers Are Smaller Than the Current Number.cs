namespace CSPS.Problems
{
    internal class How_Many_Numbers_Are_Smaller_Than_the_Current_Number : IProblem
    {
        public string Result
        {
            get
            {
                int[] nums = [8, 1, 2, 2, 3];
                int[] result = SmallerNumbersThanCurrent(nums);
                return string.Join(", ", result);
            }
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                foreach (int otherNum in nums)
                {
                    if (otherNum < nums[i])
                    {
                        count++;
                    }
                }
                result[i] = count;
            }
            return result;
        }
    }
}
