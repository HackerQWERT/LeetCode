using System;

public class 零钱兑换
{



    public int CoinChange(int[] coins, int amount)
    {
        int[] dp = new int[amount + 1];
        dp[0] = 0;
        for (int i = 1; i <= amount; i++)
        {
            int min = int.MaxValue;
            foreach (var coin in coins)
            {
                if (i - coin >= 0 && dp[i - coin] != -1)
                    min = Math.Min(min, dp[i - coin]);
            }
            dp[i] = min == int.MaxValue ? -1 : min + 1;
        }
        return dp[amount];

    }
}