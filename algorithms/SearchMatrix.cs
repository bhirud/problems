// https://leetcode.com/problems/search-a-2d-matrix/

// Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:

// Integers in each row are sorted from left to right.
// The first integer of each row is greater than the last integer of the previous row.
// For example,

// Consider the following matrix:

// [
//   [1,   3,  5,  7],
//   [10, 11, 16, 20],
//   [23, 30, 34, 50]
// ]
// Given target = 3, return true.

public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        if(matrix == null || matrix.GetLength(0) == 0)
            return false;
        int i = 0;
        int j = matrix.GetLength(1)-1;
        
        while(i < matrix.GetLength(0) && j >=0)
        {
            if(matrix[i,j] == target)
            {
                return true;
            }
            else if(matrix[i,j] < target)
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        return false;
    }
}