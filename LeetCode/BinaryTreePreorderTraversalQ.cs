using System.Collections.Generic;

namespace LeetCode
{
    public class BinaryTreePreorderTraversalQ : LeetQ
    {
        private IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> ans = new List<int>();
            if (root == null) return ans;
            TreeTraveler(root, ans);
            return ans;
        }

        private void TreeTraveler(TreeNode root, IList<int> ans)
        {
            if (root == null) return;
            ans.Add(root.val);
            TreeTraveler(root.left, ans);
            TreeTraveler(root.right, ans);
        }
    }
}