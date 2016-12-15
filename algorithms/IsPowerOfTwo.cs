// https://leetcode.com/problems/power-of-two/
// Given an integer, write a function to determine if it is a power of two.

public class Solution {
    public bool IsPowerOfTwo(int n) {
        bool power = false;
        if(n >= Int32.MaxValue) return false;
        while(n > 0)
        {
            if((n & 1) == 1)
            {
                if(power)
                    return false;
                power = true;
            }
            n = n>>1;
        }
        return power;
    }
}