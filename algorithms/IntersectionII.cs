// https://leetcode.com/problems/intersection-of-two-arrays-ii/
// Given two arrays, write a function to compute their intersection.

// Example:
// Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2, 2].

// Note:
// Each element in the result should appear as many times as it shows in both arrays.
// The result can be in any order.

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for(int i =0; i < nums1.Length; i++)
        {
            if(!dict.ContainsKey(nums1[i]))
            {
                dict.Add(nums1[i], 1);
            }
            else
            {
                dict[nums1[i]] += 1;
            }
        }
        List<int> result = new List<int>();
        
        for(int i =0; i < nums2.Length; i++)
        {
            if(dict.ContainsKey(nums2[i]) && dict[nums2[i]] > 0)
            {
                result.Add(nums2[i]);
                dict[nums2[i]] -= 1;
            }
        }
        
        return result.ToArray();
    }
}