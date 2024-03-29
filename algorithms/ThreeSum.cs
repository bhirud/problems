// https://leetcode.com/problems/3sum/

// Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

// Note: The solution set must not contain duplicate triplets.

// For example, given array S = [-1, 0, 1, 2, -1, -4],

// A solution set is:
// [
//   [-1, 0, 1],
//   [-1, -1, 2]
// ]

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
		{
			IList<IList<int>> result = new List<IList<int>> ();

			if (nums.Length < 3)
				return result;

			Array.Sort (nums);
			for(int i =0; i< nums.Length-2; i++)
			{
				if(i == 0 || nums[i] != nums[i-1])
				{
					int j = i + 1;
					int k = nums.Length - 1;

					while(j < k)
					{
						int sum = nums [i] + nums [j] + nums [k];
						if(sum == 0)
						{
							IList<int> t = new List<int> (){ nums [i], nums [j], nums [k] };
							result.Add (t);
							j++;
							k--;

							while (j < k && nums [j] == nums [j - 1])
							{
								j++;
							}
							while (j < k && nums [k] == nums [k + 1])
							{
								k--;
							}
						}
						else if(sum <0)
						{
							j++;
						}
						else
						{
							k--;
						}
					}
				}
			}

			return result;
		}
}