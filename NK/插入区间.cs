using System;
using System.Collections.Generic;
using System.Linq;

public class 插入区间
{
    // static void Main()
    // {
    //     int[][] intervals = new int[][] { new int[] { 1, 3 }, new int[] { 6, 9 } };
    //     int[] newInterval = new int[] { 2, 5 };
    //     int[][] result = new Solution().Insert(intervals, newInterval);
    //     foreach (var item in result)
    //     {
    //         Console.WriteLine($"[{item[0]},{item[1]}]");
    //     }
    // }

    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
        {
            return new int[][] { newInterval };
        }
        int start = 0;
        int end = 0;
        List<int[]> result = new List<int[]>();
        //找到新区间的起点
        for (int i = 0; i < intervals.Length; i++)
        {
            //找到第一个大于新区见起点的区间
            if (newInterval[0] <= intervals[i][1])
            {
                //如果新区见的开始点在上一个区间的终点后面，那么新区见的起点就是重复区见的起点，并且把前面的区间都加入到result
                if (newInterval[0] < intervals[i][0])
                {
                    start = newInterval[0];
                    result = intervals.Take(i).ToList();
                    break;
                }
                //如果新区间的起点在上一个区间的终点前面，那么重复区间的起点就是上一个区间的起点，并且把前面的区间都加入到result
                else
                {
                    start = intervals[i][0];
                    result = intervals.Take(i).ToList();
                    break;
                }
            }
            else if (i == intervals.Length - 1)
            {
                result = intervals.ToList();
                result.Add(newInterval);
                return result.ToArray();
            }
        }
        //找到新区间的终点
        for (int i = 0; i < intervals.Length; i++)
        {
            //找到第一个大于新区间终点的区间
            if (newInterval[1] < intervals[i][1])
            {

                //如果新区见的终点在上一个区间的起点后面，那么新区见的终点就是重复区见的终点，并且把后面的区间都加入到result
                if (newInterval[1] < intervals[i][0])
                {
                    end = newInterval[1];
                    result.Add(new int[] { start, end });
                    result.AddRange(intervals.Skip(i));
                    break;
                }
                //如果新区间的终点在上一个区间的起点前面，那么重复区间的终点就是上一个区间的终点，并且把后面的区间都加入到result
                else
                {
                    end = intervals[i][1];
                    result.Add(new int[] { start, end });
                    result.AddRange(intervals.Skip(i + 1));
                    break;
                }
            }
            //如果新区间的终点在最后一个区间的终点后面，那么新区间的终点就是重复区间的终点，并且把后面的区间都加入到result
            else if (i == intervals.Length - 1)
            {
                end = newInterval[1];
                result.Add(new int[] { start, end });
                break;
            }

        }
        return result.ToArray();
    }
}