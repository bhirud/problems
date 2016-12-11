// https://leetcode.com/problems/valid-parentheses/

// Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

// The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.

public class Solution {
    public bool IsValid(string s) {
        Stack<char> brackets = new Stack<char>();
        
        for(int i=0; i< s.Length; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                brackets.Push(s[i]);
            }
            else if(s[i] == ')')
            {
                if(brackets.Count == 0 || brackets.Peek() != '(') return false;
                brackets.Pop();
            }
            else if(s[i] == ']')
            {
                if(brackets.Count == 0 || brackets.Peek() != '[') return false;
                brackets.Pop();
            }
            else if(s[i] == '}')
            {
                if(brackets.Count == 0 || brackets.Peek() != '{') return false;
                brackets.Pop();
            }
            else
            {
                return false;
            }
        }
        
        if(brackets.Count != 0)
            return false;
        
        return true;
    }
}