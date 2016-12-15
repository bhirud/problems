// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
// Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.

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
        if(root == null)
            return null;
        
        if(!covers(root, p) || !covers(root, q))
            return null;
        
        return lca(root, p, q);
    }
    
    public TreeNode lca(TreeNode root, TreeNode p, TreeNode q)
    {
        if(root == null)
            return null;
            
        if(root == p) return p;
        if(root == q) return q;
        
        bool pOnLeft = covers(root.left, p);
        bool qOnLeft = covers(root.left, q);
        
        if(pOnLeft != qOnLeft)
            return root;
        
        TreeNode child = pOnLeft ? root.left : root.right;
        
        return lca(child, p, q);
    }
    
    public bool covers(TreeNode root, TreeNode p)
    {
        if(root == null)
            return false;
        
        return root == p || covers(root.left, p) || covers(root.right, p);
    }
}