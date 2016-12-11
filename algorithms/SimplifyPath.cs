// https://leetcode.com/problems/simplify-path/

// Given an absolute path for a file (Unix-style), simplify it.

// For example,
// path = "/home/", => "/home"

public class Solution {
    public string SimplifyPath(string path) {
        string[] str = path.Split('/');
        
       Stack<string> folder = new Stack<string>();
        for(int i =0; i< str.Length; i++)
        {
            if(str[i].Length != 0)
            {
                if(str[i] == ".." && folder.Count > 0)
                    folder.Pop();
                else if(str[i] != "." && str[i] != "..")
                    folder.Push(str[i]);
                    
            }
        }
        StringBuilder sb = new StringBuilder();
        if(folder.Count == 0)
            sb.Insert(0, "/");
            
        while(folder.Count > 0)
        {
            sb.Insert(0, "/" + folder.Pop());
        }
        
        return sb.ToString();
    }
}