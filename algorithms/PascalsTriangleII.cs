// https://leetcode.com/problems/pascals-triangle-ii/

// Given an index k, return the kth row of the Pascal's triangle.

// For example, given k = 3,
// Return [1,3,3,1].

public class Solution {
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex == 0)
                return new List<int> (){ 1};
            
            List<int> p = new List<int> (){1,1};
            //p.Add (1);
            List<int> q = new List<int> ();
            int i = 1;
            while (i < rowIndex)
            {
                for(int j =0; j<= p.Count; j++)
                {
                    if(j == 0 || j == p.Count)
                    {
                        q.Add (1);
                    }
                    else
                    {
                        q.Add (p[j] + p[j-1]);
                    }
                }
                i++;
                p = new List<int> ();
                p.AddRange(q);
                q.Clear ();
            }
            return p;
        }
}