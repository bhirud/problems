// https://leetcode.com/problems/number-of-islands/
// Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

// Example 1:
// 11110
// 11010
// 11000
// 00000
// Answer: 1

// Example 2:
// 11000
// 11000
// 00100
// 00011
// Answer: 3

public class Solution {
    public int NumIslands(char[,] grid) {
        if(grid == null || grid.GetLength(0) == 0)
            return 0;
            
        int count = 0;
        for(int i =0; i< grid.GetLength(0); i++)
        {
            for(int j =0; j< grid.GetLength(1); j++)
            {
                if(grid[i,j] == '1')
                {
                    islandSpread(grid, i, j);
                    count++;
                }
            }
        }
        
        return count;
    }
    
    void islandSpread(char[,] a, int i, int j)
    {
        if(i < 0 || i >= a.GetLength(0) || j<0 || j >= a.GetLength(1) || a[i,j] != '1')
            return;
        a[i,j] = '2';
        islandSpread(a, i+1, j);
        islandSpread(a, i-1, j);
        islandSpread(a, i, j+1);
        islandSpread(a, i, j-1);
    }
}