namespace CSPS.Problems
{
    internal class Valid_Mountain_Array : IProblem
    {
        public string Result
        {
            get
            {
                int[] arr = [0, 3, 2, 1];
                return ValidMountainArray(arr).ToString();
            }
        }
        public bool ValidMountainArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    // Check if the left side is strictly increasing
                    for (int j = 1; j < i; j++)
                    {
                        if (arr[j] <= arr[j - 1])
                            return false;
                    }
                    // Check if the right side is strictly decreasing
                    for (int k = i + 1; k < n; k++)
                    {
                        if (arr[k] >= arr[k - 1])
                            return false;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
