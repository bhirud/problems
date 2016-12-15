// https://leetcode.com/problems/excel-sheet-column-title/
// Given a positive integer, return its corresponding column title as appear in an Excel sheet.

// For example:

//     1 -> A
//     2 -> B
//     3 -> C
//     ...
//     26 -> Z
//     27 -> AA
//     28 -> AB 

public class Solution {
    public string ConvertToTitle(int n) {
        StringBuilder sb = new StringBuilder();
        
        while(n > 0)
        {
            n--;
            sb.Append((char)(n%26 + 'A'));
            n = n/26;
        }
        // char[] s = sb.ToString().ToCharArray();
        // Array.Reverse(s);
        // return string.ToString();
       return new string(sb.ToString().Reverse().ToArray());
    }
}