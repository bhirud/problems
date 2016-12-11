// https://leetcode.com/problems/add-binary/

// Given two binary strings, return their sum (also a binary string).

// For example,
// a = "11"
// b = "1"
// Return "100".

public class Solution {
    public string AddBinary(string a, string b) {
        if(a.Length == 0)
            return b;
        if(b.Length == 0)
            return a;
        int carry = 0;
        int i = a.Length - 1;
        int j = b.Length - 1;
        StringBuilder sb = new StringBuilder();
        while(i >= 0 || j >=0)
        {
            int sum = carry;
            if(i >= 0 && a[i] == '1')
                sum++;
            if(j >= 0 && b[j] == '1')
               sum++;
            
               sb.Insert(0, sum%2);
               carry = sum/2;
               i--;
               j--;
        }
        if(carry == 1)
            sb.Insert(0, 1);
        return sb.ToString();
    }
}