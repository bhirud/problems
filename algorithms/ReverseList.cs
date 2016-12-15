// https://leetcode.com/problems/reverse-linked-list/
// Reverse a singly linked list.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode p = head;
        if(p == null || p.next == null)
            return p;
        
        ListNode q = p.next;

        while(q != null)
        {
            p.next = q.next;
            q.next = head;
            head = q;
            q = p.next;
        }
        return head;
    }
}