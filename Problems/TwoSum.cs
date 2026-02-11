using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPS.Problems
{
    internal class TwoSum : IProblem
    {
        // csharp
        public string Result
        {
            get
            {
                int[] nums = { 2, 7, 11, 15 };
                int target = 9;
                string result = string.Join(", ", Solve(nums, target));
                return $"Input: nums = [{string.Join(", ", nums)}], target = {target}\nOutput: [{result}]";
            }
        }
        public static int[] Solve(int[] nums, int target)

        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return [i, j];
                }
            }
            throw new ArgumentException("No two sum solution");
        }

    }
}
