using System;

namespace LeetCode
{
    public class RemoveDuplicatesSortedListQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            
            var result = DeleteDuplicates(new ListNode(1, new ListNode(1, new ListNode(2))));
            Console.WriteLine($"Test Case ([1,1,2]) : {result}");

            result = DeleteDuplicates(new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3))))));
            Console.WriteLine($"Test Case ([1,1,2,3,3]) : {result}");
        }
        
        private ListNode DeleteDuplicates(ListNode head) {
            var trackerNode = head;

            while (trackerNode?.next != null)
            {
                if (trackerNode.val == trackerNode.next.val)
                {
                    trackerNode.next = trackerNode.next.next;
                    continue;
                }

                trackerNode = trackerNode.next;
            }

            return head;
        }
    }
}