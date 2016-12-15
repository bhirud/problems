// https://leetcode.com/problems/repeated-dna-sequences/

// All DNA is composed of a series of nucleotides abbreviated as A, C, G, and T, for example: "ACGAATTCCG". When studying DNA, it is sometimes useful to identify repeated sequences within the DNA.
// Write a function to find all the 10-letter-long sequences (substrings) that occur more than once in a DNA molecule.
// For example,
// Given s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT",

// Return:
// ["AAAAACCCCC", "CCCCCAAAAA"].

public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        List<string> result = new List<string>();
        
        if(s == null || s.Length < 10)
            return result;
            
        Dictionary<string, int> parts = new Dictionary<string, int>();
        
        for(int i=0; i<=s.Length -10; i++)
        {
            string temp = s.Substring(i, 10);
            if(parts.ContainsKey(temp))
            {
                if(parts[temp] == 1)
                {
                    result.Add(temp);
                    parts[temp] = 0;
                }
            }
            else
            {
                parts[temp] = 1;
            }
        }
        
        return result;
    }
}