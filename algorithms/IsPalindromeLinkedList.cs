// https://leetcode.com/problems/palindrome-linked-list/
// Given a singly linked list, determine if it is a palindrome.

// Follow up:
// Could you do it in O(n) time and O(1) space?

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        //1-2-3-4-5
        ListNode s = head;
        ListNode f = head;
        if(head == null) return true;
        
        while(f.next != null && f.next.next != null)
        {
            s = s.next;
            f = f.next.next;
        }
        ListNode q = s.next;
        // if(f.next != null)
        //     q = q.next;
        
        q = reverse(q);
        
        ListNode p = head;
        while(q != null)
        {
            if(p.val != q.val)
                return false;
            p = p.next;
            q = q.next;
        }
        return true;
    }

    public ListNode reverse(ListNode head)
    {
        if(head == null) return null;
        ListNode p = head;
        ListNode q = p.next;
        while(q != null)
        {
            ListNode t = q;
            q = q.next;
            t.next = head;
            head = t;
            p.next = q;
        }
        
        return head;
    }
}