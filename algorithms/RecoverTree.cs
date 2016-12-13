// https://leetcode.com/problems/recover-binary-search-tree/

// Two elements of a binary search tree (BST) are swapped by mistake.

// Recover the tree without changing its structure.

// Note:
// A solution using O(n) space is pretty straight forward. Could you devise a constant space solution?

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
    
    public TreeNode first = null;
    public TreeNode second = null;
    public TreeNode predecessor = null;
    
    void inorder(TreeNode root)
    {
        if(root == null)
            {
                return;
            }
            inorder (root.left);
            if(predecessor == null)
            {
                predecessor = root;
            }
            else
            {
                if(predecessor.val > root.val)
                {
                    if (first == null)
                    {
                        first = predecessor;
                        second = root;
                    }
                    else
                    {
                        second = root;
                        
                    }
                }
                predecessor = root;
            }
            inorder (root.right);
    }

        public void RecoverTree(TreeNode root)
        {
            if(root == null)
            {
                return;
            }
            inorder(root);
            
            int t = first.val;
            first.val = second.val;
            second.val = t;
        }
}