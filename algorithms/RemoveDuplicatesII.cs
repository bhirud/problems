// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/

// Follow up for "Remove Duplicates":
// What if duplicates are allowed at most twice?

// For example,
// Given sorted array nums = [1,1,1,2,2,3],

// Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3. It doesn't matter what you leave beyond the new length.

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums == null || nums.Length <3) return nums.Length;
        int i =0;
        int j = 1;
        int k =2;
        while(k < nums.Length)
        {
            if(nums[i] == nums[k] && nums[j] == nums[k])
            {
                k++;
            }
            else
            {
                i++;
                j++;
                nums[j] = nums[k];
                k++;
            }
            
        }
        return j+1;
    }
}