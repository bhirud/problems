// https://leetcode.com/problems/minimum-size-subarray-sum/
// Given an array of n positive integers and a positive integer s, find the minimal length of a subarray of which the sum ≥ s. If there isn't one, return 0 instead.

// For example, given the array [2,3,1,2,4,3] and s = 7,
// the subarray [4,3] has the minimal length under the problem constraint.

public class Solution {
    public int MinSubArrayLen(int s, int[] nums)
    {
        int sum = 0;
        int start =0;
        int l = nums.Length+1;
        for(int i =0; i < nums.Length; i++)

        {
            sum += nums[i];
            
            if(sum >= s)
            {
                if(start == i) return 1;
                while(sum >= s && start <= i)
                {
                    l = Math.Min(l, i- start+1);
                    if(l == 1) return 1;
                    sum -= nums[start++];
                }
            }
            
                
        }
        
        if(l == nums.Length+1)
            return 0;
        return l;
    }
}