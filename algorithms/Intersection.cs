// https://leetcode.com/problems/intersection-of-two-arrays/
// Given two arrays, write a function to compute their intersection.

// Example:
// Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2].

// Note:
// Each element in the result must be unique.
// The result can be in any order.

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for(int i =0; i < nums1.Length; i++)
        {
            if(!dict.ContainsKey(nums1[i]))
            {
                dict.Add(nums1[i], 1);
            }
        }
        List<int> result = new List<int>();
        
        for(int i =0; i < nums2.Length; i++)
        {
            if(dict.ContainsKey(nums2[i]))
            {
                result.Add(nums2[i]);
                dict.Remove(nums2[i]);
            }
        }
        
        return result.ToArray();
    }
}