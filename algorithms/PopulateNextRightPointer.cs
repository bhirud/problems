// https://leetcode.com/problems/populating-next-right-pointers-in-each-node/

// Given a binary tree

//     struct TreeLinkNode {
//       TreeLinkNode *left;
//       TreeLinkNode *right;
//       TreeLinkNode *next;
//     }
// Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.

/**
 * Definition for binary tree with next pointer.
 * public class TreeLinkNode {
 *     int val;
 *     TreeLinkNode left, right, next;
 *     TreeLinkNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void connect(TreeLinkNode root) {
        if(root == null)
            return;
        
        TreeLinkNode p = root;
        
        while(p != null)
        {
            TreeLinkNode q = p.left;
            if(q != null)
            {
                q.next = p.right;
                if(p.next != null)
                    p.right.next = p.next.left;
            }
            p = p.next;
        }
        connect(root.left);
    }
}