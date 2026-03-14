using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPS.Problems
{
    internal class Majority_Element : IProblem
    {
        public string Result { 
                get
                {
                    var nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };
                    return MajorityElement(nums).ToString();
                }
        }
        public int MajorityElement(int[] nums)
        {
            return MajorityElementRec(nums, 0, nums.Length - 1);
        }

        private int MajorityElementRec(int[] nums, int left, int right)
        {
            // Base case
            if (left == right)
            {
                return nums[left];
            }

            // Recurse on left and right halves of this slice.
            int mid = left + (right - left) / 2;
            int leftMajority = MajorityElementRec(nums, left, mid);
            int rightMajority = MajorityElementRec(nums, mid + 1, right);

           
            if (leftMajority == rightMajority)
            {
                return leftMajority;
            }

            // Otherwise, count each element and return the "winner".
            int leftCount = CountInRange(nums, leftMajority, left, right);
            int rightCount = CountInRange(nums, rightMajority, left, right);

            return leftCount > rightCount ? leftMajority : rightMajority;
        }

        private int CountInRange(int[] nums, int num, int left, int right)
        {
            int count = 0;
            for (int i = left; i <= right; i++)
            {
                if (nums[i] == num)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
