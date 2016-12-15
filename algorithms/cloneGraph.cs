// https://leetcode.com/problems/clone-graph/

// Clone an undirected graph. Each node in the graph contains a label and a list of its neighbors.

/**
 * Definition for undirected graph.
 * class UndirectedGraphNode {
 *     int label;
 *     List<UndirectedGraphNode> neighbors;
 *     UndirectedGraphNode(int x) { label = x; neighbors = new ArrayList<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    public UndirectedGraphNode cloneGraph(UndirectedGraphNode node)
    {
        if (node == null)
            return null;

        HashMap<UndirectedGraphNode, UndirectedGraphNode> visited = new HashMap<UndirectedGraphNode, UndirectedGraphNode> ();

        Queue<UndirectedGraphNode> q = new LinkedList<UndirectedGraphNode> ();

        UndirectedGraphNode c = new UndirectedGraphNode (node.label);
        
        q.add (node);
        visited.put (node, c);
        
        while(!q.isEmpty())
        {
            UndirectedGraphNode p = q.remove ();
            
                for(UndirectedGraphNode u : p.neighbors)
                {
                    if (!visited.containsKey (u))
                    {   
                        UndirectedGraphNode n = new UndirectedGraphNode (u.label);
                        visited.put(u, n);
                        visited.get(p).neighbors.add (n);
                        q.add(u);
                    }
                    else
                    {
                        visited.get(p).neighbors.add(visited.get(u));
                    }
                }


        }

        return c;
    }
}