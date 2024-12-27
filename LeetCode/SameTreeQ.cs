using System;

namespace LeetCode
{
    public class SameTreeQ : LeetQ
    {
        public override void TestCases()
        {
            base.TestCases();

            var testCase1 = IsSameTree(new TreeNode(1, new TreeNode(2), new TreeNode(3)),
                new TreeNode(1, new TreeNode(2), new TreeNode(3)));
            Console.WriteLine($"Test Case ([1,2,3], [1,2,3]) :  : {testCase1}");

            var testCase2 = IsSameTree(new TreeNode(1, new TreeNode(2)), new TreeNode(1, null, new TreeNode(2)));
            Console.WriteLine($"Test Case ([1,2], [1,null,2]) :  : {testCase2}");

            var testCase3 = IsSameTree(new TreeNode(1, new TreeNode(2), new TreeNode(1)),
                new TreeNode(1, new TreeNode(1), new TreeNode(2)));
            Console.WriteLine($"Test Case ([1,2,1], [1,1,3]) :  : {testCase3}");
        }
        
        private bool IsSameTree(TreeNode p, TreeNode q) {
            if (p == null && q == null) return true;
            if (p == null || q == null || p.val != q.val) return false;
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}