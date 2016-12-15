// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/

// Given a binary tree, flatten it to a linked list in-place.

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
    public void Flatten(TreeNode root) {
        if(root == null)
            return;
        Flatten(root.left);
        if(root.left != null)
        {
            TreeNode p = root.left;
            while(p.right != null)
            {
                p = p.right;
            }
            p.right = root.right;
            root.right = root.left;
            root.left = null;
        }
        Flatten(root.right);
    }
}