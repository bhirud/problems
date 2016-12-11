// https://leetcode.com/problems/3sum-closest/

// Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target. Return the sum of the three integers. You may assume that each input would have exactly one solution.

//     For example, given array S = {-1 2 1 -4}, and target = 1.

//     The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        	int min = Int32.MaxValue;
			int result = 0;

			Array.Sort (nums);

			for(int i =0; i < nums.Length-2; i++)
			{
				if(i == 0 || nums[i] != nums[i-1])
				{
					int j = i + 1;
					int k = nums.Length - 1;
					while(j < k)
					{
						int sum = nums [i] + nums [j] + nums [k];
						int diff = Math.Abs (sum - target);
						if (diff == 0)
							return sum;
						
						if(min > diff)
						{
							min = diff;
							result = sum;
						}
						if(sum < target)
							j++;
						else
							k--;
					}
				}
			}

			return result;
    }
}