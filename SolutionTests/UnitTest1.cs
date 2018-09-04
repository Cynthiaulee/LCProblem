using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LCProblem;
using System.Linq;
using DataStructures;
namespace SolutionTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestTwoSum()
        {
            int[] nums = new int[] { 3, 4, 5, 9 };
            int target = 9;
            int[] expected = new int[] { 1, 2 };
            // Act
            Solution sol = new Solution();
            // Assert
            int[] actual = sol.TwoSum(nums, target);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod]
        public void TestAddTwoNumbers()
        {
            ListNode l1 = new ListNode(2);
            ListNode start = l1;
            start.next = new ListNode(4);
            start = start.next;
            start.next = new ListNode(3);
            start = start.next;
            ListNode l2 = new ListNode(5);
            start = l2;
            start.next = new ListNode(6);
            start = start.next;
            start.next = new ListNode(4);
            start = start.next;
            ListNode expected = new ListNode(7);
            start = expected;
            start.next = new ListNode(0);
            start = start.next;
            start.next = new ListNode(8);
            start = start.next;
            Solution sol = new Solution();
            ListNode Ans = sol.AddTwoNumbers(l1, l2);
            bool notEqual = false;
            for (int i = 1; i < 3; i++)
            {
                if (expected.val != Ans.val)
                {
                    notEqual = true;
                }
                expected = expected.next;
                Ans = Ans.next;
            }
            Assert.AreEqual(notEqual, false);
        }
        [TestMethod]
        public void TestLengthOfLongestSubstring()
        {
            string s = "dvdf";
            int expected = 3;
            // Act
            Solution sol = new Solution();
            // Assert
            int actual = sol.LengthOfLongestSubstring(s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestFindMedianSortedArrays()
        {
            int[] nums1 = new int[0];
            int[] nums2 = new int[1];
            nums2[0] = 1;
            double expected = 1;
            // Act
            Solution sol = new Solution();
            // Assert
            double actual = sol.FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestLongestPalindrome()
        {
            string s = "a";
            string expected = "a";
            // Act
            Solution sol = new Solution();
            // Assert
            string actual = sol.LongestPalindrome(s);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestConvert()
        {
            string s = "PAYPALISHIRING";
            string expected = "PINALSIGYAHRPI";
            //string expected = "A";
            // Act
            Solution sol = new Solution();
            // Assert
            string actual = sol.Convert(s, 4);
            Assert.AreEqual(expected, actual);
        }
    }
}
