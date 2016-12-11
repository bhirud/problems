// https://leetcode.com/problems/rotate-image/

// You are given an n x n 2D matrix representing an image.

// Rotate the image by 90 degrees (clockwise).

// Follow up:
// Could you do this in-place?

public class Solution {
    public void Rotate(int[,] matrix) {
        if(matrix == null || matrix.GetLength(0) == 0)
            return;
            int l = matrix.GetLength(0)-1;
        for(int i=0; i<= l; i++)
        {
            for(int j =i; j< l-i; j++)
            {
                int temp = matrix[i,j];
                matrix[i,j] = matrix[l-j, i];
                matrix[l-j, i] = matrix[l-i,l-j];
                matrix[l-i,l-j] = matrix[j, l-i];
                matrix[j, l-i] = temp;
            }
        }
    }
}