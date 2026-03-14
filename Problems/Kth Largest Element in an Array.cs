using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPS.Problems
{
    internal class Kth_Largest_Element_in_an_Array : IProblem
    {
        public string Result => FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2).ToString();

        public int FindKthLargest(int[] nums, int k)
        {
            MergeSort(nums, 0, nums.Length - 1);
            return nums[nums.Length - k];
        }

        private void MergeSort(int[] nums, int left, int right)
        {
            if (left >= right)
                return;

            int mid = left + (right - left) / 2;

            // Divide
            MergeSort(nums, left, mid);        // sort left half
            MergeSort(nums, mid + 1, right);   // sort right half

            // Conquer
            Merge(nums, left, mid, right);     // merge both halves
        }

        private void Merge(int[] nums, int left, int mid, int right)
        {
            int leftSize = mid - left + 1;
            int rightSize = right - mid;

            int[] leftArr = new int[leftSize];
            int[] rightArr = new int[rightSize];

            Array.Copy(nums, left, leftArr, 0, leftSize);
            Array.Copy(nums, mid + 1, rightArr, 0, rightSize);

            int i = 0, j = 0, k = left;

            while (i < leftSize && j < rightSize)
            {
                if (leftArr[i] <= rightArr[j])
                    nums[k++] = leftArr[i++];
                else
                    nums[k++] = rightArr[j++];
            }

            while (i < leftSize) nums[k++] = leftArr[i++];
            while (j < rightSize) nums[k++] = rightArr[j++];
        }
    }
}