using System;

public class 完全平方数
{
    public int NumSquares(int n)
    {
        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            int j = 1;
            int min = int.MaxValue;
            while (i - j * j >= 0)
            {
                min = Math.Min(dp[i - j * j], min);
                j++;
            }
            dp[i] = min + 1;
        }
        return dp[n];

    }
}