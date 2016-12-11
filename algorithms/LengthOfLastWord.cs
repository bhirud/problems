// https://leetcode.com/problems/length-of-last-word/

// Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.

// If the last word does not exist, return 0.

// Note: A word is defined as a character sequence consists of non-space characters only.

// For example, 
// Given s = "Hello World",
// return 5.

public class Solution {
    public int LengthOfLastWord(string s) {
        if(s == null)
            return 0;
        s = s.Trim();
        if(s.Length == 0)
            return 0;
            
        int i = s.Length -1;
        int count = 0;
        while(i >= 0)
        {
            if(s[i] != ' ')
                count++;
            else
                break;
            i--;
        }
        return count;
    }
}