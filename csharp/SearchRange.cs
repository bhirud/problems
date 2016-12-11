// https://leetcode.com/problems/search-for-a-range/

// Given a sorted array of integers, find the starting and ending position of a given target value.

// Your algorithm's runtime complexity must be in the order of O(log n).

// If the target is not found in the array, return [-1, -1].

// For example,
// Given [5, 7, 7, 8, 8, 10] and target value 8,
// return [3, 4].

public class Solution {
    public int[] SearchRange(int[] a, int target) {
        int[] range = new int[]{-1,-1};
        if(a == null || a.Length == 0)
            return range;
            
        int s = 0;
        int e = a.Length-1;
        while(s <= e)
        {
            int m = (s+e)/2;
            if(a[m] == target)
            {
                if(m == 0 || m == a.Length-1)
                {
                    range[0] = m;
                    break;
                }
                else if( m > 0 && m < a.Length && a[m-1] != a[m])
                {
                    range[0] = m;
                    break;   
                }
                e = m;
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
        
        s = Math.Max(range[0],0);
        e = a.Length-1;
        while(s <= e)
        {
            int m = (e+s)/2;
            if(a[m] == target)
            {
                if(m == a.Length-1)
                {
                    range[1] = m;
                    break;
                }
                else if( m >= 0 && m < a.Length-1 && a[m+1] != a[m])
                {
                    range[1] = m;
                    break;
                }
                if(m<e && a[m] ==a[m+1])
                    s = m+1;
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
        
        return range;
    }
}