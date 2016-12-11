// https://leetcode.com/problems/rotate-list/

// Given a list, rotate the list to the right by k places, where k is non-negative.

// For example:
// Given 1->2->3->4->5->NULL and k = 2,
// return 4->5->1->2->3->NULL.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(k < 0 || head == null)
            return head;
        int length = getLength(head);
        k = k% length;
        
        if(k == 0) return head;
        
        ListNode p = head;
        
        while(p.next != null && k > 0)
        {
            p = p.next;
            k--;
        }
        
        ListNode q = head;
        
        while(p.next != null)
        {
            p = p.next;
            q = q.next;
        }
        
        ListNode newHead = q.next;
        q.next = null;
        p.next = head;
        
        return newHead;
    }
    
    int getLength(ListNode p)
    {
        int count = 0;
        
        while(p != null)
        {
            count++;
            p = p.next;
        }
        
        return count;
    }
}