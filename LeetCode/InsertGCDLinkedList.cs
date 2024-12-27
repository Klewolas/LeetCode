using System;

namespace LeetCode
{
    public class InsertGCDLinkedList : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();

            var result = InsertGreatestCommonDivisors(new ListNode(18, new ListNode(6, new ListNode(10, new ListNode(3)))));
            Console.WriteLine($"Test Case ([18,6,10,3]) : {result}");

            result = InsertGreatestCommonDivisors(new ListNode(7));
            Console.WriteLine($"Test Case ([7]) : {result}");
        }
        
        private ListNode InsertGreatestCommonDivisors(ListNode head) {
            var trackerNode = head;

            while (trackerNode?.next != null)
            {
                trackerNode.next = new ListNode(GCD(trackerNode.val, trackerNode.next.val), trackerNode.next);
                trackerNode = trackerNode.next.next;
            }

            return head;
        }

        private int GCD(int a, int b)
        {
            int result = Math.Min(a, b);
            while (result > 0) {
                if (a % result == 0 && b % result == 0) {
                    break;
                }
                result--;
            }

            return result;
        }
        
    }
}