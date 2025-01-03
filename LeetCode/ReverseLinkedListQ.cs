using System;

namespace LeetCode
{
    public class ReverseLinkedListQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            
            var result = ReverseList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
            Console.WriteLine($"Test Case ([1,2,3,4,5]) : {result}");
        }
        
        private ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            ListNode next = null;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}