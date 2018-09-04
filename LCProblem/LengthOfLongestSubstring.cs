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
    }
}
