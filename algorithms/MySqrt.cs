// https://leetcode.com/problems/sqrtx/

// Implement int sqrt(int x).

// Compute and return the square root of x.

public class Solution {
    public int MySqrt(int x)
    {
        long start = 0;
        long end = x/2;
        if(x == 1) return 1;
        while(start <= end)
        {
            long m = (start + end)/2;
            long square = m*m;
            if(square == (long)x)
                return (int)m;
            else if(x < square)
            {
                end = m-1;
            }
            else
            {
                start = m+1;
            }
        }
        return (int)end;
    }
}