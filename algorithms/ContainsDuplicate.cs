// https://leetcode.com/problems/contains-duplicate/
// Given an array of integers, find if the array contains any duplicates. Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if(nums == null || nums.Length ==0)
        {
            return false;
        }
        HashSet<int> d = new HashSet<int>();
        for(int i =0; i<nums.Length; i++)
        {
            if(d.Contains(nums[i]))
                return true;
            else
            {
                d.Add(nums[i]);
            }
        }
        
        return false;
    }
}