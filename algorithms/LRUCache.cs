// https://leetcode.com/problems/lru-cache/
// Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and set.
// get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
// set(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.

public class Pair
{
    public int key;
    public int value;
    public Pair(int k, int v)
    {
        key = k;
        value = v;
    }
}

public class LRUCache
{
    Dictionary<int, LinkedListNode<Pair>> nodes;
    LinkedList<Pair> l;
    int MAX;
    
    public LRUCache(int capacity)
    {
        nodes = new Dictionary<int, LinkedListNode<Pair>>();
        l = new LinkedList<Pair>();
        MAX = capacity;
    }

    public int Get(int key)
    {
        if(!nodes.ContainsKey(key))
            return -1;
            
        LinkedListNode<Pair> temp = nodes[key];
        l.Remove(temp);
        l.AddFirst(temp);
        return temp.Value.value;
    }

    public void Set(int key, int value)
    {
        if(nodes.ContainsKey(key))
        {
            LinkedListNode<Pair> temp = nodes[key];
            l.Remove(temp);
            temp = new LinkedListNode<Pair>(new Pair(key, value));
            l.AddFirst(temp);
            nodes[key] = temp;
        }
        else
        {
            LinkedListNode<Pair> temp = new LinkedListNode<Pair>(new Pair(key, value));
            l.AddFirst(temp);
            nodes[key] = temp;
            while(l.Count > MAX)
            {
                
                LinkedListNode<Pair> t = l.Last;
                l.RemoveLast();
                nodes.Remove(t.Value.key);
            }
        }
    }
}