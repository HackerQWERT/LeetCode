// using System;
// using System.Collections.Generic;

// public class Solution
// {
//     //     在给定的 m x n 网格 grid 中，每个单元格可以有以下三个值之一：

//     // 值 0 代表空单元格；
//     // 值 1 代表新鲜橘子；
//     // 值 2 代表腐烂的橘子。
//     // 每分钟，腐烂的橘子 周围 4 个方向上相邻 的新鲜橘子都会腐烂。

//     // 返回 直到单元格中没有新鲜橘子为止所必须经过的最小分钟数。如果不可能，返回 -1 。
//     public int OrangesRotting(int[][] grid)
//     {
//         //当前腐烂橘子索引list
//         HashSet<Tuple<int, int>> current = new HashSet<Tuple<int, int>>();
//         //扩散新鲜橘子索引list
//         HashSet<Tuple<int, int>> next = new HashSet<Tuple<int, int>>();
//         int freshOranges = 0;
//         //获取当前腐烂橘子索引
//         for (int i = 0; i < grid.Length; i++)
//         {
//             for (int j = 0; j < grid[0].Length; j++)
//             {
//                 if (grid[i][j] == 2)
//                 {
//                     current.Add(new Tuple<int, int>(i, j));
//                 }
//                 else if (grid[i][j] == 1)
//                 {
//                     freshOranges++;
//                 }
//             }
//         }
//         int minutes = 0;
//         while (true)
//         {
//             //获取扩散新鲜橘子索引
//             foreach (var item in current)
//             {
//                 int i = item.Item1;
//                 int j = item.Item2;
//                 //获取四个方向的合法索引并压入next
//                 //←
//                 if (i - 1 >= 0 && grid[i - 1][j] == 1)
//                     next.Add(new Tuple<int, int>(i - 1, j));
//                 //→
//                 if (i + 1 < grid.Length && grid[i + 1][j] == 1)
//                     next.Add(new Tuple<int, int>(i + 1, j));
//                 //↑
//                 if (j - 1 >= 0 && grid[i][j - 1] == 1)
//                     next.Add(new Tuple<int, int>(i, j - 1));
//                 //↓
//                 if (j + 1 < grid[0].Length && grid[i][j + 1] == 1)
//                     next.Add(new Tuple<int, int>(i, j + 1));
//             }

//             //如果扩散队列为空，还有新鲜橘子了，返回-1
//             if (next.Count == 0 && freshOranges > 0)
//                 return -1;
//             //如果没有新鲜橘子了，返回分钟数
//             if (freshOranges == 0)
//                 return minutes;
//             freshOranges -= next.Count;
//             minutes++;
//             //扩散
//             foreach (var item in next)
//             {
//                 grid[item.Item1][item.Item2] = 2;
//             }
//             current = next;
//             next = new HashSet<Tuple<int, int>>();
//         }

//     }
// }