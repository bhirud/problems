// https://leetcode.com/problems/increasing-triplet-subsequence/
// Given an unsorted array return whether an increasing subsequence of length 3 exists or not in the array.

// Formally the function should:
// Return true if there exists i, j, k 
// such that arr[i] < arr[j] < arr[k] given 0 ≤ i < j < k ≤ n-1 else return false.
// Your algorithm should run in O(n) time complexity and O(1) space complexity.

// Examples:
// Given [1, 2, 3, 4, 5],
// return true.

// Given [5, 4, 3, 2, 1],
// return false.

public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        if(nums == null || nums.Length ==0) return false;
        int a =nums[0];
        int b = Int32.MaxValue;
        int c = Int32.MaxValue;
        
        for(int i =0; i < nums.Length; i++)
        {
            c= nums[i];
            if(c <= a)
                a = c;
            else if(c <= b)
                b = c;
            else
            {
                return true;
            }
        }
        return false;
    }
}