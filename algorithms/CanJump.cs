// https://leetcode.com/problems/jump-game/

// Given an array of non-negative integers, you are initially positioned at the first index of the array.

// Each element in the array represents your maximum jump length at that position.

// Determine if you are able to reach the last index.

// For example:
// A = [2,3,1,1,4], return true.

// A = [3,2,1,0,4], return false.

public class Solution {
    public bool CanJump(int[] nums) {
        if(nums == null || nums.Length ==0)
            return false;
        int current = nums[0];
        
        for(int i=1; i< nums.Length; i++)
        {
            if(current < i)
                return false;
            
            current = Math.Max(current, i+nums[i]);
        }
        return true;
    }
}