// https://leetcode.com/problems/add-two-numbers/

// You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
// Output: 7 -> 0 -> 8

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1 == null)
            return l2;
        if(l2 == null)
            return l1;
            
        ListNode head = new ListNode(0);
        ListNode p = head;
        int carry =0;
        while(l1 != null || l2 != null)
        {
            if(l1 != null)
            {
                carry += l1.val;
                l1 = l1.next;
            }
            if(l2 != null)
            {
                carry += l2.val;
                l2 = l2.next;
            }
            ListNode temp = new ListNode(carry % 10);
            carry /= 10;
            p.next = temp;
            p = p.next;
        }
        
        if(carry > 0)
        {
            ListNode temp = new ListNode(carry);
            p.next = temp;
            p = p.next;
        }
        
        return head.next;
    }
}