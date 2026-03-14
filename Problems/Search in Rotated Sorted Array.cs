using System;

namespace CSPS.Problems;

public class Search_in_Rotated_Sorted_Array : IProblem
{
    public string Result => Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0).ToString();

    public int Search(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0)
        {
            return -1;
        }

        return SearchDivideAndConquer(nums, target, 0, nums.Length - 1);
    }

    private int SearchDivideAndConquer(int[] nums, int target, int left, int right)
    {
        if (left > right)
        {
            return -1;
        }

        int mid = left + (right - left) / 2;

        if (nums[mid] == target)
        {
            return mid;
        }

        // At least one side is sorted; pick the side where target can exist.
        if (nums[left] <= nums[mid])
        {
            if (target >= nums[left] && target < nums[mid])
            {
                return SearchDivideAndConquer(nums, target, left, mid - 1);
            }

            return SearchDivideAndConquer(nums, target, mid + 1, right);
        }

        if (target > nums[mid] && target <= nums[right])
        {
            return SearchDivideAndConquer(nums, target, mid + 1, right);
        }

        return SearchDivideAndConquer(nums, target, left, mid - 1);
    }
}
