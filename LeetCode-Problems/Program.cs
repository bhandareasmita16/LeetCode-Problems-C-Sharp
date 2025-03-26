// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LeetCode_Problems.Common;
using LeetCode_Problems.Problems;

AddTwoNumbers solution = new AddTwoNumbers();

// Create two linked lists
ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3))); // 342
ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4))); // 465

// Call AddTwoNumbers
ListNode result = solution.AddTwoNumber(l1, l2);
solution.PrintList(result);
