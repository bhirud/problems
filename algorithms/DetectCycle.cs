// https://leetcode.com/problems/linked-list-cycle-ii/
// Given a linked list, return the node where the cycle begins. If there is no cycle, return null.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode f = head;
        ListNode s = head;
        
        if(head == null || head.next == null)
        {
            return null;
        }
        
        while(f != null && f.next != null)
        {
            s = s.next;
            f = f.next.next;
            if(s == f)
            {
                break;
            }
        }
        
        if(f == null || f.next == null)
        {
            return null;
        }
        
        s = head;
        
        while(s != f)
        {
            s = s.next;
            f = f.next;
        }
        return f;
    }
}