namespace CSPS.Problems
{
    internal class ConcatenationofArray
    {
        public string Result
        {
            get
            {
                int[] nums = [1, 2, 1];
                int[] result = GetConcatenation(nums);
                return string.Join(", ", result);
            }
        }
        public int[] GetConcatenation(int[] nums)
        {
            int[] result = new int[nums.Length * 2];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
                result[i + nums.Length] = nums[i];
            }

            return result;
        }
    }
}
