// https://leetcode.com/problems/valid-palindrome/

// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

// For example,
// "A man, a plan, a canal: Panama" is a palindrome.
// "race a car" is not a palindrome.

using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        string pattern = "[^a-zA-Z0-9]";
        string replacement = "";
        Regex rgx = new Regex(pattern);
        string result = rgx.Replace(s, replacement);
        //bool f = true;
        for(int i =0; i < result.Length/2; i++)
        {
            if(result[i] != result[result.Length-i-1])
            {
                return false;
            }
        }
        
        return true;
    }
}