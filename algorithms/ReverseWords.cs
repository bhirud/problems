// https://leetcode.com/problems/reverse-words-in-a-string/
// Given an input string, reverse the string word by word.

// For example,
// Given s = "the sky is blue",
// return "blue is sky the".

public class Solution {
    public string ReverseWords(string s) {
        if(s == null || s.Length == 0)
            return "";
        
        s = s.Trim();
        List<char> c = new List<char>();
        
        for(int k=0; k< s.Length; k++)
        {
            if(k == 0 || s[k] != ' ' || (s[k] == ' ' && s[k] != s[k-1]))
                c.Add(s[k]);
        }
        
        reverse(c, 0, c.Count-1);
        int i =0;
        int j = 1;
        while(j <= c.Count)
        {
            if(j == c.Count || (c[j] == ' ' && c[j] != c[j-1]))
            {
                reverse(c, i, j-1);
                i = j+1;
            }
            j++;
        }
        s = string.Join("", c).Trim();
        // Console.WriteLine(s.Length);
        return s;
    }
    
    void reverse(List<char> c, int i, int j)
    {
        while(i < j)
        {
            char t = c[i];
            c[i] = c[j];
            c[j] = t;
            i++;
            j--;
        }
    }
}