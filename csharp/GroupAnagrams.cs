// https://leetcode.com/problems/anagrams/

// Given an array of strings, group anagrams together.

// For example, given: ["eat", "tea", "tan", "ate", "nat", "bat"], 
// Return:

// [
//   ["ate", "eat","tea"],
//   ["nat","tan"],
//   ["bat"]
// ]

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> d = new Dictionary<string, IList<string>>();
        for(int i =0; i< strs.Length; i++)
        {
            string s = String.Concat(strs[i].OrderBy(c => c));
            if(!d.ContainsKey(s))
                d[s] = new List<string>();
            
            d[s].Add(strs[i]);
        }
        return d.Values.ToList();
    }
}