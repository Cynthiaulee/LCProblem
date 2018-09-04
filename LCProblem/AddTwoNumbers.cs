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
    }

}
