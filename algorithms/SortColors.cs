// https://leetcode.com/problems/sort-colors/

// Given an array with n objects colored red, white or blue, sort them so that objects of the same color are adjacent, with the colors in the order red, white and blue.

// Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.

public class Solution {
    public void SortColors(int[] a)
    {
            int red = 0;
            int blue = a.Length - 1;

            for (int i = 0; i < a.Length; i++)
            {
                if (i > blue || blue - red < 1)
                    break;
                
                if(a[i] == 0)
                {
                    ReplaceColor (a, i, red);
                    red++;
                }
                else if(a[i] == 2)
                {
                    while (blue >0 && a [blue] == 2)
                        blue--;
                    if (blue > red && blue >= i) {
                        ReplaceColor (a, i, blue);
                        blue--;

                        if (a [i] == 0) {
                            ReplaceColor (a, i, red);
                            red++;
                        }
                    }
                }
            }
    }
    
    public void ReplaceColor(int[]a , int color1, int color2)
    {
        int t = a [color1];
        a [color1] = a [color2];
        a [color2] = t;
    }
}