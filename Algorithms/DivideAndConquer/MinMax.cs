using System;
using CSPS.Problems;

namespace CSPS.Algorithms.DivideAndConquer
{
    internal class MinMax : IProblem
    {
        public string Result
        {
            get
            {
                int[] result = FindMinMax(new int[] { 3, 1, 4, 1, 5, 9 });
                return $"Min = {result[0]}, Max = {result[1]}";
            }
        }

        int[] FindMinMax(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Array must contain at least one element.");
            }

            return FindMinMaxRec(0, nums.Length - 1, nums);
        }

        int[] FindMinMaxRec(int left, int right, int[] arr)
        {
            // Base case: one element -> it is both min and max.
            if (left == right)
            {
                return new int[] { arr[left], arr[left] };
            }

            // Base case: two elements -> compare once and return [min, max].
            if (left == right - 1)
            {
                if (arr[left] < arr[right])
                {
                    return new int[] { arr[left], arr[right] };
                }

                return new int[] { arr[right], arr[left] };
            }

            // Divide: split current range into two halves.
            int mid = (left + right) / 2;

            // Conquer: find [min, max] for each half.
            int[] leftResult = FindMinMaxRec(left, mid, arr);
            int[] rightResult = FindMinMaxRec(mid + 1, right, arr);

            // Combine: min is the smaller min, max is the larger max.
            int min = Math.Min(leftResult[0], rightResult[0]);
            int max = Math.Max(leftResult[1], rightResult[1]);

            return new int[] { min, max };
        }
    }
}
