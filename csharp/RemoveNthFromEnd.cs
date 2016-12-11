// https://leetcode.com/problems/remove-nth-node-from-end-of-list/

// Given a linked list, remove the nth node from the end of list and return its head.

// For example,

//    Given linked list: 1->2->3->4->5, and n = 2.

//    After removing the second node from the end, the linked list becomes 1->2->3->5.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null)
        {
            return head;
        }
        if(head.next == null && n == 1)
        {
            return head.next;
        }
        
        ListNode p = head;
        for(int i =0; i < n; i++)
        {
            p = p.next;
        }
        if(p == null)
        {
            return head.next;
        }
        
        ListNode q = head;
        while(p.next != null)
        {
            p = p.next;
            q = q.next;
        }
        q.next = q.next.next;
        
        return head;
    }
}