// https://leetcode.com/problems/binary-tree-level-order-traversal/

// Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> levels = new List<IList<int>>();
    
        if(root == null)
            return levels;
        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);
        while(nodes.Count > 0)
        {
            levels.Add(nodes.Select(v => v.val).ToList());
            Queue<TreeNode> temp = new Queue<TreeNode>();
            while(nodes.Count > 0)
            {
                TreeNode p = nodes.Dequeue();
                if(p.left != null)
                    temp.Enqueue(p.left);
                if(p.right != null)
                    temp.Enqueue(p.right);
            }
            nodes = temp;
        }
        
        return levels;
    }
}