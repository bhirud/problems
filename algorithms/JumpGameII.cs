// https://leetcode.com/problems/jump-game-ii/

// Given an array of non-negative integers, you are initially positioned at the first index of the array.

// Each element in the array represents your maximum jump length at that position.

// Your goal is to reach the last index in the minimum number of jumps.

// For example:
// Given array A = [2,3,1,1,4]

// The minimum number of jumps to reach the last index is 2. (Jump 1 step from index 0 to 1, then 3 steps to the last index.)

public class Solution {
    public int Jump(int[] a) {
        if(a == null || a.Length == 0)
            return 0;
        
        int[] jumps = new int[a.Length];
        jumps[0] = 0;
        
        int last = 1;
        
        for(int i=0; i < a.Length; i++)
        {
            int jump = a[i];
            jump = jump - (last-i-1);
            
            while(jump > 0 && last < a.Length)
            {
                jumps[last] = jumps[i]+1;
                last++;
                jump--;
            }
            
            if(last == a.Length)
                return jumps[last-1];
        }
        
        return jumps[a.Length-1];
    }
}