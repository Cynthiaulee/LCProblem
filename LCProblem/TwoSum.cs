using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace LCProblem
{
    public partial class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // Two sum problem:
            // Given an array of integers, return indices of the two numbers 
            // such that they add up to a specific target.
            // You may assume that each input would have exactly one solution, 
            // and you may not use the same element twice.
            // Example: 
            // Given nums = [2, 7, 11, 15], target = 9,
            // Because nums[0] + nums[1] = 2 + 7 = 9,
            // return [0, 1].
            int[] result = new int[2] { -1, -1 };
            Dictionary<int, int> numsMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numsMap.ContainsKey(nums[i]))
                {
                    if (target == 2 * nums[i])
                    {
                        result[0] = numsMap[nums[i]];
                        result[1] = i;
                        return result;
                    }
                }
                else
                    numsMap.Add(nums[i], i);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numsMap.ContainsKey(complement) && numsMap[complement] != i)
                {
                    result[0] = numsMap[nums[i]];
                    result[1] = numsMap[complement];
                    return result;
                }
            }
            throw new System.ArgumentException("No two sum solution");
        }
    }
}
