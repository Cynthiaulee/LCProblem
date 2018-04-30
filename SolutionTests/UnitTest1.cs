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
            Solution sol = new Solution();
            ListNode Ans = sol.AddTwoNumbers(l1, l2);
        }
    }
}
