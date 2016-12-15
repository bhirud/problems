// https://leetcode.com/problems/maximum-product-subarray/

// Find the contiguous subarray within an array (containing at least one number) which has the largest product.
// For example, given the array [2,3,-2,4],
// the contiguous subarray [2,3] has the largest product = 6.

public class Solution {
    public int MaxProduct(int[] nums) {
        if(nums == null || nums.Length == 0)
        {
            return 0;
        }
        if(nums.Length == 1)
            return nums[0];
            
        int min = nums[0];
        int max = nums[0];
        int product = nums[0];
        
        for(int i =1; i< nums.Length; i++)
        {
            if(nums[i] > 0)
            {
                max = Math.Max(nums[i], max*nums[i]);
                min = Math.Min(nums[i], min*nums[i]);    
            }
            else
            {
                int t = max;
                max = Math.Max(nums[i], min*nums[i]);
                min = Math.Min(nums[i], t*nums[i]);
            }
            product = Math.Max(product, max);
        }
        return product;
    }
}