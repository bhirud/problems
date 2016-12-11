// https://leetcode.com/problems/powx-n/

// Implement pow(x, n).

public class Solution {
    public double MyPow(double x, int n) {
        return n<0 ? 1/pow(x,-n) : pow(x,n);
    }
    
    double pow(double x, int n)
    {
        if(n == 0) return 1;
        if(n == 1) return x;
        
        double p = pow(x, n/2);
        
        if(n % 2 == 0)
        {
            return p*p;
        }
        else
        {
            return x * p * p;
        }
    }
}