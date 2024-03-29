// https://leetcode.com/problems/search-insert-position/

// Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

// You may assume no duplicates in the array.

// Here are few examples.
// [1,3,5,6], 5 → 2
// [1,3,5,6], 2 → 1
// [1,3,5,6], 7 → 4
// [1,3,5,6], 0 → 0

public class Solution {
    public int SearchInsert(int[] a, int target) {
        if(a == null || a.Length == 0)
        {
            return -1;
        }
        
        int s =0;
        int e = a.Length-1;
        
        while(s<=e)
        {
            int m = (s+e)/2;
            if(a[m] == target)
            {
                return m;
            }
            else if(a[m] < target)
            {
                s = m+1;   
            }
            else
            {
                e = m-1;
            }
        }
        
        return s;
    }
}