using CSPS.Problems;

namespace CSPS.Algorithms.DivideAndConquer
{
    internal class SearchIndex : IProblem
    {
        public string Result
        {
            get
            {
                int[] arr = [-10, -5, 0, 3, 7, 9];
                return Search(0, arr.Length - 1, arr).ToString();
            }
        }
        public static int Search(int left, int right, int[] arr)
        {
            if (left == right)
            {
                if (arr[left] == left)
                {
                    return left;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                int mid = (left + right) / 2;
                if (arr[mid] == mid)
                {
                    return mid;
                }
                if (arr[mid] > mid)
                {
                    return Search(left, mid - 1, arr);
                }
                else
                {
                    return Search(mid + 1, right, arr);

                }

            }
        }
    }
}
