// https://leetcode.com/problems/valid-perfect-square/
// Given a positive integer num, write a function which returns True if num is a perfect square else False.

// Note: Do not use any built-in library function such as sqrt.
// Example 1:
// Input: 16
// Returns: True
// Example 2:
// Input: 14
// Returns: False

public class Solution {
    public bool IsPerfectSquare(int n) {
            long s = 1;
            long e = (n >> 1) + 1;

            while(s <= e)
            {
                long m = s + ((e - s) >> 1);
                long square = m * m;

                if(square == n)
                {
                    return true;
                }
                else if(square > n)
                {
                    e = m - 1;
                }
                else
                {
                    s = m + 1;
                }
            }

            return false;
    }
}