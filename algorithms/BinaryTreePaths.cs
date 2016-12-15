// https://leetcode.com/problems/binary-tree-paths/
// Given a binary tree, return all root-to-leaf paths.

// For example, given the following binary tree:

//    1
//  /   \
// 2     3
//  \
//   5
// All root-to-leaf paths are:

// ["1->2->5", "1->3"]

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
    public IList<string> BinaryTreePaths(TreeNode root) {
       List<string> result = new List<string>();
       if (root == null) {
            return result;
        }
        
        allPaths(root, new List<int> (), result);
        return result;
 
    }
    
    public void allPaths(TreeNode root, List<int> path, List<string> result)
    {
        if(root == null)
            return;
        path.Add(root.val);
        if(root.left == null && root.right == null)
        {
            result.Add(string.Join("->", path));
        }
        allPaths(root.left, path, result);
        allPaths(root.right, path, result);
        
        path.RemoveAt(path.Count-1);
    }
}