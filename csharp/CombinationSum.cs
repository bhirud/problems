// https://leetcode.com/problems/combination-sum/

// Given a set of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.

// The same repeated number may be chosen from C unlimited number of times.

// Note:
// All numbers (including target) will be positive integers.
// The solution set must not contain duplicate combinations.
// For example, given candidate set [2, 3, 6, 7] and target 7, 
// A solution set is: 
// [
//   [7],
//   [2, 2, 3]
// ]

public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
			IList<IList<int>> result = new List<IList<int>>();
			if(candidates == null || candidates.Length ==0)
				return result;

			Array.Sort(candidates);
			combSum(candidates, 0, new List<int>(), 0, target, result);
			return (IList<IList<int>>)result;
		}

		public void combSum(int[] a, int index, List<int> l, int sum, int target, IList<IList<int>> result)
		{
			if(a.Length == index || sum > target)
				return;
			if(sum == target)
			{
				result.Add(new List<int>(l));
				return;
			}

			l.Add(a[index]);
			combSum(a,index, l, sum+ a[index], target, result);
			l.RemoveAt(l.Count -1);
			combSum(a, index+1, l, sum, target, result);
		}
}