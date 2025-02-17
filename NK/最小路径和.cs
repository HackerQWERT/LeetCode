// using System;
// using System.Diagnostics;

// public class Solution
// {
//     int sum = 0;
//     int min = int.MaxValue;
//     private int[][] grid;
//     int m;
//     int n;
//     static void Main()
//     {
//         //计算时间
//         Stopwatch sw = new Stopwatch();
//         Solution s = new Solution();
//         int[][] grid = new int[18][]{
//             new int[]{3,8,6,0,5,9,9,6,3,4,0,5,7,3,9,3}, new int[]{0,9,2,5,5,4,9,1,4,6,9,5,6,7,3,2}, new int[]{8,2,2,3,3,3,1,6,9,1,1,6,6,2,1,9}, new int[]{1,3,6,9,9,5,0,3,4,9,1,0,9,6,2,7}, new int[]{8,6,2,2,1,3,0,0,7,2,7,5,4,8,4,8}, new int[]{4,1,9,5,8,9,9,2,0,2,5,1,8,7,0,9}, new int[]{6,2,1,7,8,1,8,5,5,7,0,2,5,7,2,1}, new int[]{8,1,7,6,2,8,1,2,2,6,4,0,5,4,1,3}, new int[]{9,2,1,7,6,1,4,3,8,6,5,5,3,9,7,3}, new int[]{0,6,0,2,4,3,7,6,1,3,8,6,9,0,0,8}, new int[]{4,3,7,2,4,3,6,4,0,3,9,5,3,6,9,3}, new int[]{2,1,8,8,4,5,6,5,8,7,3,7,7,5,8,3}, new int[]{0,7,6,6,1,2,0,3,5,0,8,0,8,7,4,3}, new int[]{0,4,3,4,9,0,1,9,7,7,8,6,4,6,9,5}, new int[]{6,5,1,9,9,2,2,7,4,2,7,2,2,3,7,2}, new int[]{7,1,9,6,1,2,7,0,9,6,6,4,4,5,1,0}, new int[]{3,4,9,2,8,3,1,2,6,9,7,0,2,4,2,0}, new int[]{5,1,8,8,4,6,8,5,2,4,1,6,2,2,9,7}
//         };
//         sw.Start();
//         Console.WriteLine(s.MinPathSum(grid));
//         sw.Stop();
//         Console.WriteLine("Time: {0}ms", sw.ElapsedMilliseconds);
//     }
//     public int MinPathSum(int[][] grid)
//     {
//         this.grid = grid;
//         m = grid.Length;
//         n = grid[0].Length;
//         DFS(0, 0);
//         return min;
//     }

//     private void DFS(int x, int y)
//     {
//         sum += grid[x][y];
//         if (x == m - 1 && y == n - 1)
//         {
//             min = Math.Min(min, sum);
//             sum -= grid[x][y];
//             return;
//         }
//         if (y + 1 < n)
//             DFS(x, y + 1);
//         if (x + 1 < m)
//             DFS(x + 1, y);
//         sum -= grid[x][y];
//     }
// }
using System;
using System.Diagnostics;

public class 最小路径和
{

    public int MinPathSum(int[][] grid)
    {
        int[][] dp = new int[grid.Length][];
        int m = grid.Length;
        int n = grid[0].Length;
        for (int i = 0; i < grid.Length; i++)
        {
            dp[i] = new int[grid[i].Length];
        }
        dp[0][0] = grid[0][0];
        for (int i = 1; i < m; i++)
            dp[i][0] = grid[i][0] + dp[i - 1][0];
        for (int i = 1; i < n; i++)
            dp[0][i] = grid[0][i] + dp[0][i - 1];
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                dp[i][j] = grid[i][j] + Math.Min(dp[i - 1][j], dp[i][j - 1]);
            }
        }
        return dp[m - 1][n - 1];
    }

}