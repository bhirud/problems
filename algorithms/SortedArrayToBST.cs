// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/

// Given an array where elements are sorted in ascending order, convert it to a height balanced BST.

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
    public TreeNode SortedArrayToBST(int[] a) {
        if(a == null || a.Length == 0)
        {
            return null;
        }
        
        return BST(a,0,a.Length-1);
    }
    
    public TreeNode BST(int[] a, int s, int e)
    {
        if(s > e)
        {
            return null;
        }
        
        int m = (s+e)/2;
        TreeNode root = new TreeNode(a[m]);
        root.left = BST(a, s, m-1);
        root.right = BST(a, m+1, e);
        return root;
    }
}