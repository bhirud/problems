// https://leetcode.com/problems/insert-interval/

// Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).

// You may assume that the intervals were initially sorted according to their start times.

// Example 1:
// Given intervals [1,3],[6,9], insert and merge [2,5] in as [1,5],[6,9].

// Example 2:
// Given [1,2],[3,5],[6,7],[8,10],[12,16], insert and merge [4,9] in as [1,2],[3,10],[12,16].

// This is because the new interval [4,9] overlaps with [3,5],[6,7],[8,10].

/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
    {
       List<Interval> r = new List<Interval>();
        int i =0;
        while(i< intervals.Count)
        {
            if(newInterval.start > intervals[i].end)
            {
                r.Add(intervals[i]);
            }
            else if(newInterval.end < intervals[i].start)
            {
                r.Add(newInterval);
                newInterval = intervals[i];
            }
            else //if(newInterval.start <= intervals[i].end || newInterval.end >= intervals[i].start)
            {
                newInterval = new Interval(Math.Min(newInterval.start, intervals[i].start), Math.Max(newInterval.end, intervals[i].end));
            }
            i++;
        }
        r.Add(newInterval);
        return r;
    }
}