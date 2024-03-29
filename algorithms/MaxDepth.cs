// https://leetcode.com/problems/maximum-depth-of-binary-tree/

// Given a binary tree, find its maximum depth.
// The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

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
    public int MaxDepth(TreeNode root)
    {
        if(root == null)
            return 0;
        
        return 1+ Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}