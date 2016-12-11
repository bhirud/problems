// https://leetcode.com/problems/spiral-matrix/

// Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.

// For example,
// Given the following matrix:

// [
//  [ 1, 2, 3 ],
//  [ 4, 5, 6 ],
//  [ 7, 8, 9 ]
// ]
// You should return [1,2,3,6,9,8,7,4,5].

public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        List<int> result = new List<int>();
        
        if(matrix == null || matrix.GetLength(0) == 0)
            return result;
            
            int t = 0;
            int b = matrix.GetLength(0)-1;
            int l = 0;
            int r = matrix.GetLength(1)-1;
            //2, 1,1,1
            while(t <= r && l<=r)
            {
                //1,2,3,12
                //5,6
                for(int i= l; i <= r; i++)
                {
                    result.Add(matrix[t,i]);
                }
                t++;
                if(t>b)break;
                //13,14
                for(int i= t; i <= b; i++)
                {
                    result.Add(matrix[i,r]);
                }
                r--;
                //9,8,7
                if(l>r)break;
                for(int i= r; i >= l; i--)
                {
                    result.Add(matrix[b, i]);
                }
                b--;
                //4
                if(t>b)break;
                for(int i= b; i >= t; i--)
                {
                    result.Add(matrix[i,l]);
                }
                l++;
            }
            
            return result;
    }
}