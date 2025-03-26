using LeetCode_Problems.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Problems
{
    public class AddTwoNumbers
    {
        public ListNode AddTwoNumber(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int val1 = (l1 != null) ? l1.val : 0;
                int val2 = (l2 != null) ? l2.val : 0;

                int sum = val1 + val2 + carry;
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return dummy.next;
        }
        public void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val);
                if (head.next != null)
                    Console.Write(" -> ");
                head = head.next;
            }
            Console.WriteLine();
        }
    }
}


