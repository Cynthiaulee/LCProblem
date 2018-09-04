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
            int lenS = s.Length;
            IDictionary<char, int> charDict = new Dictionary<char, int>();
            int idx = 1;
            for (int i = 0; i < lenS; i++)
            {
                if (!charDict.ContainsKey(s[i])){
                    charDict[s[i]] = idx;
                    idx++;
                }
            }
            return "ababa";
        }
    }
}
