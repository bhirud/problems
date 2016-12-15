// https://leetcode.com/problems/sum-root-to-leaf-numbers/

// Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.
// An example is the root-to-leaf path 1->2->3 which represents the number 123.
// Find the total sum of all root-to-leaf numbers.

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
    int sum = 0;
    public int SumNumbers(TreeNode root) {
        sumNumbers(root, "");
        return sum;
    }
    public void sumNumbers(TreeNode root, string s)
    {
        if(root == null)
            return;
        if(root.left == null && root.right == null)
        {
            s = s+ root.val;
            sum += int.Parse(s);
            return;
        }
        sumNumbers(root.left, s+root.val);
        sumNumbers(root.right, s+root.val);
    }
}