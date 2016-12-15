// https://leetcode.com/problems/candy/

// There are N children standing in a line. Each child is assigned a rating value.
// You are giving candies to these children subjected to the following requirements:
// Each child must have at least one candy.
// Children with a higher rating get more candies than their neighbors.

using System.Linq;
public class Solution {
    public int Candy(int[] ratings) {
        if(ratings == null || ratings.Length == 0)
            return 0;
            
        int[] candies = new int[ratings.Length];
        
        candies[0] = 1;
        
        for(int i=1; i< candies.Length; i++)
        {
            if(ratings[i] > ratings[i-1])
            {
                candies[i] = candies[i-1]+1;
            }
            else
            {
                candies[i] = 1;
            }
        }
        
        for(int i=candies.Length-2; i>=0; i--)
        {
            if(ratings[i] > ratings[i+1])
            {
                candies[i] = Math.Max(candies[i+1]+1, candies[i]);
            }
        }
        
        return candies.Sum();
    }
}