// https://leetcode.com/problems/copy-list-with-random-pointer/

// A linked list is given such that each node contains an additional random pointer which could point to any node in the list or null.
// Return a deep copy of the list.

/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
    public RandomListNode CopyRandomList(RandomListNode head)
    {
        if( head == null)
            return null;
        
        Dictionary<RandomListNode, RandomListNode> nodes = new Dictionary<RandomListNode, RandomListNode>();
        
        RandomListNode p = head;
        RandomListNode newHead = new RandomListNode(0);
        RandomListNode q = newHead;
        while(p != null)
        {
            RandomListNode temp = new RandomListNode(p.label);
            q.next = temp;
            q = temp;
            nodes.Add(p, temp);
            p = p.next;
        }
        
        p = head;
        q = newHead.next;
        
        while(p != null)
        {
            RandomListNode temp = null;
            if(p.random != null)
            {
                nodes.TryGetValue(p.random, out temp);
            }
            q.random = temp;
            p = p.next;
            q = q.next;
        }
        
        return newHead.next;
    }
}