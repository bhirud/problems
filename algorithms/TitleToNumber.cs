// https://leetcode.com/problems/excel-sheet-column-number/
// Given a column title as appear in an Excel sheet, return its corresponding column number.

// For example:

//     A -> 1
//     B -> 2
//     C -> 3
//     ...
//     Z -> 26
//     AA -> 27
//     AB -> 28 

public class Solution {
    public int TitleToNumber(string s) {
        if(s == null || s.Length == 0)
            return 0;
        int n =0;
        for(int i =0; i< s.Length; i++)
        {
            n = n*26 + s[i] - 'A' + 1;
        }
        return n;
    }
}