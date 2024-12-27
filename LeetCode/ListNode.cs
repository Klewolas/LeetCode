namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            string s = "[";

            var tNode = this;

            while (tNode != null)
            {
                s += $"{tNode.val}";
                if (tNode.next != null)
                    s += ",";
                tNode = tNode.next;
            }

            s += "]";
            return s;
        }
    }
}