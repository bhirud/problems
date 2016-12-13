// https://leetcode.com/problems/merge-sorted-array/

// Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int k = nums1.Length-1;
        int i = m-1;
        int j = nums2.Length-1;
        
        while(j >= 0)
        {
            if(i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}