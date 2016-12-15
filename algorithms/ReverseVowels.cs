// https://leetcode.com/problems/reverse-vowels-of-a-string/
// Write a function that takes a string as input and reverse only the vowels of a string.

// Example 1:
// Given s = "hello", return "holle".

// Example 2:
// Given s = "leetcode", return "leotcede".

// Note:
// The vowels does not include the letter "y".

public class Solution {
        public string ReverseVowels(string str)
        {
            char[] s = str.ToCharArray ();
            int i = 0;
            int j = s.Length - 1;
            Dictionary<char, int> vowels = new Dictionary<char, int> ();
            vowels.Add ('a',1);
            vowels.Add ('e',1);
            vowels.Add ('i',1);
            vowels.Add ('o',1);
            vowels.Add ('u',1);
            vowels.Add ('A',1);
            vowels.Add ('E',1);
            vowels.Add ('I',1);
            vowels.Add ('O',1);
            vowels.Add ('U',1);
            while(i < j)
            {
                if (vowels.ContainsKey (s [i]))
                {
                    while(!vowels.ContainsKey(s[j]))
                    {
                        j--;
                    }
                    if(i < j)
                    {
                        char t = s [i];
                        s [i] = s [j];
                        s [j] = t;
                    }
                    j--;
                }
                i++;
            }
            return new string(s);
        }
}