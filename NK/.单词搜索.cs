using System;
using System.Collections.Generic;

public class 单词搜索
{
    private bool isFound = false;
    private char[][] board;
    private string word;
    // private HashSet<(int i, int j)> path = new HashSet<(int i, int j)>();
    private bool[,] visited;
    public bool Exist(char[][] board, string word)
    {
        this.board = board;
        this.word = word;
        visited = new bool[board.Length, board[0].Length];
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == word[0])
                {
                    DFS(i, j, 0);
                    if (isFound)

                        return true;
                }
            }
        }
        return false;
    }

    private void DFS(int i, int j, int index)
    {
        if (isFound)
            return;
        if (index == word.Length - 1)
        {
            isFound = true;
            return;
        }
        visited[i, j] = true;
        // path.Add((i, j));
        // if (i > 0 && !path.Contains((i - 1, j)) && board[i - 1][j] == word[index + 1])
        //     DFS(i - 1, j, index + 1);
        // if (i < board.Length - 1 && !path.Contains((i + 1, j)) && board[i + 1][j] == word[index + 1])
        //     DFS(i + 1, j, index + 1);
        // if (j > 0 && !path.Contains((i, j - 1)) && board[i][j - 1] == word[index + 1])
        //     DFS(i, j - 1, index + 1);
        // if (j < board[i].Length - 1 && !path.Contains((i, j + 1)) && board[i][j + 1] == word[index + 1])
        //     DFS(i, j + 1, index + 1);
        // path.Remove((i, j));

        if (i > 0 && !visited[i - 1, j] && board[i - 1][j] == word[index + 1])
            DFS(i - 1, j, index + 1);
        if (i < board.Length - 1 && !visited[i + 1, j] && board[i + 1][j] == word[index + 1])
            DFS(i + 1, j, index + 1);
        if (j > 0 && !visited[i, j - 1] && board[i][j - 1] == word[index + 1])
            DFS(i, j - 1, index + 1);
        if (j < board[i].Length - 1 && !visited[i, j + 1] && board[i][j + 1] == word[index + 1])

            DFS(i, j + 1, index + 1);
        visited[i, j] = false;
    }
}
