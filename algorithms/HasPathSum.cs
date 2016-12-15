// https://leetcode.com/problems/path-sum/

// Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.

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
    public bool HasPathSum(TreeNode root, int sum) {
        if(root == null)
            return false;
            
        if(root.left == null && root.right == null && root.val == sum)
            return true;
            
        return HasPathSum(root.left, sum - root.val) ||
                HasPathSum(root.right, sum - root.val);
    }
}