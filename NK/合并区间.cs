// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Solution
// {
//     public static void Main()
//     {
//         int[][] intervals = new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
//         int[][] res = new Solution().Merge(intervals); // [[1,6],[8,10],[15,18]]
//         //输出格式[[1,6],[8,10],[15,18]]
//         Console.Write("[");
//         foreach (var item in res)
//         {
//             Console.Write("[" + item[0] + "," + item[1] + "]");
//         }
//         Console.WriteLine("]");

//     }
//     public int[][] Merge(int[][] intervals)
//     {

//         intervals = intervals.OrderBy(x => x[0]).ToArray();
//         List<int[]> mergedList = new List<int[]>();
//         for (int i = 0; i < intervals.Length; i++)
//         {
//             if (mergedList.Count == 0 || mergedList.Last()[1] < intervals[i][0])
//                 mergedList.Add(new int[] { intervals[i][0], intervals[i][1] });
//             else
//                 mergedList.Last()[1] = Math.Max(mergedList.Last()[1], intervals[i][1]);
//         }
//         return mergedList.ToArray();
//     }
// }
