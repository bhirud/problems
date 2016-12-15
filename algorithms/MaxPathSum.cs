// https://leetcode.com/problems/binary-tree-maximum-path-sum/

// Given a binary tree, find the maximum path sum.

// For this problem, a path is defined as any sequence of nodes from some starting node to any node in the tree along the parent-child connections. The path must contain at least one node and does not need to go through the root.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int max = Int32.MinValue;
    public int MaxPathSum(TreeNode root) {
        path(root);
        return max;
    }
    public int path(TreeNode root)
    {
        if(root == null)
            return 0;
            
        int l = path(root.left);
        int r = path(root.right);
        int current = Math.Max(root.val, Math.Max(l+ root.val, r+root.val));
        
        max = Math.Max(Math.Max(current, l+ root.val+r), max);
        return current;
    }
}