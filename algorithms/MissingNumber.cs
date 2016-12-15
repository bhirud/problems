// https://leetcode.com/problems/missing-number/
// Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

// For example,
// Given nums = [0, 1, 3] return 2.

using System.Linq;
public class Solution {
    public int MissingNumber(int[] nums) {
        if(nums == null || nums.Length == 0)
            return 0;
            
        double sum = nums.Length *(nums.Length+1)/2;
        
        double arraySum = nums.Sum();
        
        return (int)(sum-arraySum);
    }
}