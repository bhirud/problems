// https://leetcode.com/problems/binary-tree-preorder-traversal/
// Given a binary tree, return the preorder traversal of its nodes' values.

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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        
        if(root == null)
            return result;
        
        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);
        while(s.Count > 0)
        {
            TreeNode p = s.Pop();
            result.Add(p.val);
            if(p.right != null)
                s.Push(p.right);
            if(p.left != null)
                s.Push(p.left);
        }
        
        return result;
    }
}