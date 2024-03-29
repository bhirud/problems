// https://leetcode.com/problems/validate-binary-search-tree/

// Given a binary tree, determine if it is a valid binary search tree (BST).

// Assume a BST is defined as follows:

// The left subtree of a node contains only nodes with keys less than the node's key.
// The right subtree of a node contains only nodes with keys greater than the node's key.
// Both the left and right subtrees must also be binary search trees.

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
    public bool IsValidBST(TreeNode root) {
        return isValid(root, Double.NegativeInfinity, Double.PositiveInfinity);
    }
    
    public bool isValid(TreeNode root, double min, double max)
    {
        if(root == null)
            return true;
        
        return (root.val > min && root.val < max) &&
            isValid(root.left, min, root.val) &&
            isValid(root.right, root.val, max);
    }
}