﻿namespace LeetCode
{
    public class SearchInBinarySearchTreeQ : LeetQ
    {
        private TreeNode SearchBST(TreeNode root, int val) {
            if (root == null || root.val == val)
                return root;

            if (root.val < val)
                return SearchBST(root.right, val);

            return SearchBST(root.left, val);
        }
    }
}