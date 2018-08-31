using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace LCProblem
{
    public class Solution
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

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // Add two numbers problem:
            // You are given two non - empty linked lists representing two non - negative integers.
            // The digits are stored in reverse order and each of their nodes contain a single digit.
            // Add the two numbers and return it as a linked list.
            // You may assume the two numbers do not contain any leading zero, except the number 0 itself.
            // Example:
            // Input: (2-> 4-> 3) +(5-> 6-> 4)
            // Output: 7-> 0-> 8
            // Explanation: 342 + 465 = 807.
            int overflow = 0;
            ListNode result = new ListNode(-1);
            ListNode start = result;

            while (l1 != null || l2 != null)
            {
                int val1 = l1 == null ? 0 : l1.val;
                int val2 = l2 == null ? 0 : l2.val;
                int added = (overflow + val1 + val2) % 10;
                ListNode newnode = new ListNode(added);
                start.next = newnode;
                start = start.next;
                overflow = (overflow + val1 + val2) / 10;
                #pragma warning disable IDE0031 // Use null propagation
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
                #pragma warning restore IDE0031 // Use null propagation
            }
            if (overflow == 1)
            {
                ListNode newnode = new ListNode(1);
                start.next = newnode;
            }
            return result.next;
        }
        public int LengthOfLongestSubstring(string s)
        {
            // Given a string find the length of the longest substring 
            // without repeating characters.
            // Example: 
            // Input: "abcabcbb"
            // Output: 3
            // Explanation: The answer is "abc", which the length is 3.
            int length = s.Length;
            int maxSubLen = 0;
            if (length > 1)
            {
                List<int> visited = new List<int> (256);
                for (int i = 0; i < 256; i++)
                {
                    visited.Add(-1);
                }
                int start = -1;
                for (int i = 0; i < length; i++)
                {
                    if (visited[s[i]] > start)
                    {
                        start = visited[s[i]];
                    }
                    visited[s[i]] = i;
                    maxSubLen = (i - start) > maxSubLen ? (i - start) : maxSubLen;
                }
                return maxSubLen;
            }
            else
            {
                return length;
            }
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // There are two sorted arrays nums1 and nums2 of size m and n 
            // respectively.
            // Find the median of the two sorted arrays. 
            // The overall run time complexity should be O(log (m+n)).
            // You may assume nums1 and nums2 cannot be both empty.
            // Example:
            // nums1 = [1, 2]
            // nums2 = [3, 4]
            // The median is (2 + 3) / 2 = 2.5
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            double median = 0;
            int[] combArr = new int[len1 + len2];
            int start1 = 0;
            int start2 = 0;
            if (len1 == 0)
            {
                if (len2 % 2 == 1)
                {
                    median = nums2[(len2 - 1) / 2];
                }
                else
                {
                    median = (nums2[len2 / 2 - 1] + nums2[len2 / 2]) / 2.0;
                }
            }
            else if (len2 == 0)
            {
                if ((len1) % 2 == 1)
                {
                    median = nums1[(len1 - 1) / 2];
                }
                else
                {
                    median = (nums1[len1 / 2 - 1] + nums1[len1 / 2]) / 2.0;
                }
            }
            else
            {
                for (int i = 0; i < (len1 + len2); i++)
                {
                    if (start1 == len1)
                    {
                        combArr[i] = nums2[start2];
                        start2++;
                    }
                    else if (start2 == len2)
                    {
                        combArr[i] = nums1[start1];
                        start1++;
                    }
                    else
                    {
                        if (nums1[start1] < nums2[start2])
                        {
                            combArr[i] = nums1[start1];
                            if (start1 < len1)
                            {
                                start1++;
                            }
                        }
                        else
                        {
                            combArr[i] = nums2[start2];
                            if (start2 < len2)
                            {
                                start2++;
                            }
                        }
                    }
                }
                if ((len1 + len2) % 2 == 1)
                {
                    median = combArr[(len1 + len2 - 1) / 2];
                }
                else
                {
                    median = (combArr[(len1 + len2) / 2 - 1] + combArr[(len1 + len2) / 2]) / 2.0;
                }
            }
            return median;
        }

        [STAThread]
        static void Main()
        {
       

        }
    }

}
