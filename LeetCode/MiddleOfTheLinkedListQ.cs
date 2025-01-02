using System;

namespace LeetCode
{
    public class MiddleOfTheLinkedListQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();
            
            var result = MiddleNode(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
            Console.WriteLine($"Test Case ([1,2,3,4,5]) : {result}");

            result = MiddleNode(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))));
            Console.WriteLine($"Test Case ([1,2,3,4,5,6]) : {result}");
        }
        
        private ListNode MiddleNode(ListNode head)
        {
            int count = 0;
            var trackerNode = head;

            while (trackerNode != null)
            {
                count++;
                trackerNode = trackerNode.next;
            }

            var middle = count / 2;

            var node = head;
            for (int i = 0; i < middle; i++)
            {
                node = node.next;
            }

            return node;
        }
    }
}