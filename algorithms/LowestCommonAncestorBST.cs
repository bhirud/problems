// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
// Given a binary search tree (BST), find the lowest common ancestor (LCA) of two given nodes in the BST.

// According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes v and w as the lowest node in T that has both v and w as descendants (where we allow a node to be a descendant of itself).”

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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null) return null;
        //if(!search(root, p) || !search(root, q)) return false;
        while(root != null)
        {
            bool pSide = p.val <= root.val ? true : false;
            bool qSide = q.val <= root.val ? true : false;
            if(pSide != qSide)
                return root;
            else
            {
                if(root == p || root == q) return root;
                root = pSide ? root.left : root.right;
            }
        }
        return null;
    }
}