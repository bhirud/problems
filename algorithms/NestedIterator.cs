// https://leetcode.com/problems/flatten-nested-list-iterator/
// Given a nested list of integers, implement an iterator to flatten it.

// Each element is either an integer, or a list -- whose elements may also be integers or other lists.

// Example 1:
// Given the list [[1,1],2,[1,1]],

// By calling next repeatedly until hasNext returns false, the order of elements returned by next should be: [1,1,2,1,1].

// Example 2:
// Given the list [1,[4,[6]]],

// By calling next repeatedly until hasNext returns false, the order of elements returned by next should be: [1,4,6].

/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator
{
    Stack<NestedInteger> s = new Stack<NestedInteger>();

    public NestedIterator(IList<NestedInteger> nestedList)
    {
        for(int i =nestedList.Count-1; i>=0; i--)
        {
            s.Push(nestedList[i]);
        }
    }

    public bool HasNext()
    {
        while(s.Count > 0)
        {
            NestedInteger n = s.Peek();
            if(n.IsInteger())
                return true;
            else
            {
                IList<NestedInteger> t = s.Pop().GetList();
                for(int i =t.Count-1; i>=0; i--)
                {
                    s.Push(t[i]);
                }
            }
        }
        return false;
    }

    public int Next()
    {
        return s.Pop().GetInteger();   
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */