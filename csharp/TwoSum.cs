// https://leetcode.com/problems/two-sum/

// Given an array of integers, return indices of the two numbers such that they add up to a specific target.

// You may assume that each input would have exactly one solution.

// Example:
// Given nums = [2, 7, 11, 15], target = 9,

// Because nums[0] + nums[1] = 2 + 7 = 9,
// return [0, 1].


public int[] TwoSum(int[] nums, int target)
{
		Dictionary<int, int> dict = new Dictionary<int, int> ();
		for(int i = 0; i < nums.Length; i++)
		{
			if(dict.ContainsKey(target - nums[i]))
			{
				return new int[] { dict [target - nums [i]], i };
			}
			else
			{
				dict [nums [i]] = i;
			}
		}
		return null;
}