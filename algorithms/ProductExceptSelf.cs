// https://leetcode.com/problems/product-of-array-except-self/
// Given an array of n integers where n > 1, nums, return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

// Solve it without division and in O(n).

// For example, given [1,2,3,4], return [24,12,8,6].

// Follow up:
// Could you solve it with constant space complexity? (Note: The output array does not count as extra space for the purpose of space complexity analysis.)

public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];
        int[] result = new int[nums.Length];
        
        for(int i =0; i < nums.Length; i++)
        {
            int j = nums.Length - i-1;
            
            if(i == 0)
                left[0] = nums[0];
            else
                left[i] = nums[i] * left[i-1];
            
            if(j == nums.Length -1)
                right[nums.Length-1] = nums[nums.Length-1];
            else
                right[j] = nums[j] * right[j+1];  
        }
        result[0] = right[1];
        result[nums.Length-1] = left[nums.Length-2];
        for(int i =1; i < nums.Length-1; i++)
        {
            result[i] = left[i-1]*right[i+1];
        }

        return result;
    }
}