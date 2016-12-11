// https://leetcode.com/problems/letter-combinations-of-a-phone-number/

// Given a digit string, return all possible letter combinations that the number could represent.

// A mapping of digit to letters (just like on the telephone buttons) is given below.

// Input:Digit string "23"
// Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].

public class Solution {
    public Dictionary<char, string> d = new Dictionary<char, string>();
    public IList<string> letter = new List<string>();
    
    
    public IList<string> LetterCombinations(string digits)
    {
        d['0'] = "";
        d['1'] = "";
        d['2'] = "abc";
        d['3'] = "def";
        d['4'] = "ghi";
        d['5'] = "jkl";
        d['6'] = "mno";
        d['7'] = "pqrs";
        d['8'] = "tuv";
        d['9'] = "wxyz";
        
        if(digits.Length == 0)
        {
            return letter;
        }
       
        LetterCombinations(digits, 0, "");
        return letter;
    }
    
    public void LetterCombinations(string digits, int index, string l)
    {
        if(index == digits.Length)
        {
            letter.Add(l);
            return;
        }
        
        for(int i =0; i < d[digits[index]].Length; i++)
        {
            LetterCombinations(digits, index + 1, l+d[digits[index]][i]);
        }
    }
}