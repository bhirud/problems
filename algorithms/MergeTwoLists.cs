// https://leetcode.com/problems/merge-two-sorted-lists/

// Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if(l1 == null)
            return l2;
            
        if(l2 == null)
            return l1;
            
        ListNode head = new ListNode(0);
        ListNode p = head;
        
        while(l1 != null && l2 != null)
        {
            ListNode temp = null;
            if(l1.val <= l2.val)
            {
                temp = new ListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                temp = new ListNode(l2.val);
                l2 = l2.next;
            }
            p.next = temp;
            p = p.next;
        }
        
        if(l1 == null)
        {
            p.next = l2;
        }
        else if(l2 == null)
        {
            p.next = l1;
        }
        
        return head.next;
    }
}