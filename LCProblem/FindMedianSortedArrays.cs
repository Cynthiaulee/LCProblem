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
    }
}
