namespace CSPS.Problems
{
    internal class ShuffleTheArray : IProblem
    {
        public string Result
        {
            get
            {
                int[] arr = [2, 5, 1, 3, 4, 7];
                int n = 3;
                int[] result = Shuffle(arr, n); return string.Join(", ", result);
            }
        }
        public int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = i % 2 == 0 ? nums[i / 2] : nums[n + i / 2];
            }
            return result;
        }
    }
}
