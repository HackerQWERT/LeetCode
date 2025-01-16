using System;
using System.Collections.Generic;
using System.Linq;

public class 岛屿数量
{
    // static void Main(string[] args)
    // {
    //     char[][] grids = new char[][] { new char[] { '1', '1', '0', '0', '0' }, new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '0', '1', '0', '0' }, new char[] { '0', '0', '0', '1', '1' } };
    //     Console.WriteLine(new Solution().NumIslands(grids));    // 1                        
    // }
    private int count = 0;
    public int NumIslands(char[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    DFS(grid, i, j);
                    count++;
                }
            }
        }
        return count;
    }

    private void DFS(char[][] grid, int i, int j)
    {
        grid[i][j] = '2';
        if (i > 0 && grid[i - 1][j] == '1') DFS(grid, i - 1, j);
        if (j > 0 && grid[i][j - 1] == '1') DFS(grid, i, j - 1);
        if (i < grid.Length - 1 && grid[i + 1][j] == '1') DFS(grid, i + 1, j);
        if (j < grid[i].Length - 1 && grid[i][j + 1] == '1') DFS(grid, i, j + 1);
    }
}