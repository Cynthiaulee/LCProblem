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
        public string LongestPalindrome(string s)
        {
            // Given a string s, find the longest palindromic substring in s. 
            // You may assume that the maximum length of s is 1000.
            // Example: 
            // Input: "babad"
            // Output: "bab"
            // Note: "aba" is also a valid answer.
            //IDictionary<char, int> charDict = new Dictionary<char, int>();
            //int idx = 1;
            //for (int i = 0; i < lenS; i++)
            //{
            //    if (!charDict.ContainsKey(s[i])){
            //        charDict[s[i]] = idx;
            //        idx++;
            //    }
            //}
            int lenS = s.Length;
            int subStart = 0;
            int subEnd = 0;
            int maxLen = 0;
            int maxStart = 0;
            for (int i = 0; i < lenS; i++)
            {
                if ((lenS - i) < maxLen)
                {
                    continue;
                }
                for (int j = 0; j < lenS; j++)
                {
                    subStart = i;
                    subEnd = lenS - j - 1;
                    if ((subEnd - subStart) < maxLen)
                    {
                        continue;
                    }
                    while ((subStart <= subEnd)&&s[subStart] == s[subEnd])
                    {
                        subStart++;
                        subEnd--;
                    }
                    if (((subEnd - subStart) <= 0) && ((lenS - i - j) > maxLen))
                    {
                        maxLen = lenS - i - j;
                        maxStart = i; 
                    }
                }
            }
            return s.Substring(maxStart, maxLen);
        }
    }
}
