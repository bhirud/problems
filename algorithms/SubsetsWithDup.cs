// https://leetcode.com/problems/subsets-ii/

// Given a collection of integers that might contain duplicates, nums, return all possible subsets.

// Note: The solution set must not contain duplicate subsets.

// For example,
// If nums = [1,2,2], a solution is:

// [
//   [2],
//   [1],
//   [1,2,2],
//   [2,2],
//   [1,2],
//   []
// ]

public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        int n = (int)Math.Pow(2, nums.Length) ;
        List<IList<int>> result = new List<IList<int>>();
        Dictionary<string, IList<int>> r = new Dictionary<string, IList<int>>();
        for(int i =0; i < n; i++)
        {
            List<int> comb = new List<int>();
            
            int j =i;
            int index =0;
            while(j > 0)
            {
                if((j & 1) == 1)
                    comb.Add(nums[index]);
                j = j >> 1;
                index++;
            }
            string s = string.Join(" ", comb.ToArray());
            if(!r.ContainsKey(s))
                r[s] = comb;
            
        }
        
        return r.Values.ToList();
    }
}