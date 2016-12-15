// https://leetcode.com/problems/binary-search-tree-iterator/
// Implement an iterator over a binary search tree (BST). Your iterator will be initialized with the root node of a BST.

// Calling next() will return the next smallest number in the BST.
// Note: next() and hasNext() should run in average O(1) time and uses O(h) memory, where h is the height of the tree.

/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class BSTIterator {

    Stack<TreeNode> s;
    public BSTIterator(TreeNode root) {
        s = new Stack<TreeNode>();
        while(root != null)
        {
            s.Push(root);
            root = root.left;
        }
    }

    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return s.Count > 0;
    }

    /** @return the next smallest number */
    public int Next() {
        TreeNode temp = null;
       // while(HasNext())
        {
            temp = s.Pop();
            TreeNode p = temp.right;
            while(p != null)
            {
                s.Push(p);
                p = p.left;
            }
        }
        return temp.val;
    }
}

/**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */