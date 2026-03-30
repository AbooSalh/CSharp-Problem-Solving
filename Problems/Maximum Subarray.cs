using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPS.Problems
{
    internal class Maximum_Subarray : IProblem
    {
        public string Result => MaxSubArray([-1,3,4,-5,9,-2]).ToString();
        public int MaxSubArray(int[] nums)
        {
            return MaxSubArrayRec(nums, 0, nums.Length - 1);
        }

        private int MaxSubArrayRec(int[] nums, int left, int right)
        {
            // Base case
            if (left == right)
            {
                return nums[left];
            }

            int mid = left + (right - left) / 2;

            // max left
            int leftMax = MaxSubArrayRec(nums, left, mid);

            // max right
            int rightMax = MaxSubArrayRec(nums, mid + 1, right);

            // max crossing
            int crossMax = MaxCrossingSum(nums, left, mid, right);


            return Math.Max(Math.Max(leftMax, rightMax), crossMax);
        }

        private int MaxCrossingSum(int[] nums, int left, int mid, int right)
        {
            // max left
            int leftSum = int.MinValue;
            int sum = 0;
            for (int i = mid; i >= left; i--)
            {
                sum += nums[i];
                if (sum > leftSum)
                {
                    leftSum = sum;
                }
            }

            // max right
            int rightSum = int.MinValue;
            sum = 0;
            for (int i = mid + 1; i <= right; i++)
            {
                sum += nums[i];
                if (sum > rightSum)
                {
                    rightSum = sum;
                }
            }

            return leftSum + rightSum;
        }
    }
}
