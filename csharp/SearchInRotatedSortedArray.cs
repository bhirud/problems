// https://leetcode.com/problems/search-in-rotated-sorted-array/

// Suppose a sorted array is rotated at some pivot unknown to you beforehand.

// (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

// You are given a target value to search. If found in the array return its index, otherwise return -1.

// You may assume no duplicate exists in the array.

public class Solution {
    public int Search(int[] nums, int target) {
        int s = 0;
        int e = nums.Length-1;
        
        while(s <= e)
        {
            int m = (s+e)/2;
            
            if(nums[m] == target)
                return m;
            if(nums[s] <=  nums[m])
            {
                if(nums[s] <= target && target <= nums[m])
                {
                e = m-1;
                }
                else
                {
                    s = m+1;
                }
            }
            else
            {
                if(nums[m] <= target && target <= nums[e])
                {
                    s = m+1;
                }
                else
                {
                    e = m-1;
                }
            }
        }
        return -1;
    }
}