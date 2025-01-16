using System;

public class 买卖股票的最佳时机
{
    public int MaxProfit(int[] prices)
    {
        int min = int.MaxValue;
        int max = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else
            {
                max = Math.Max(max, prices[i] - min);
            }
        }

        return max;
    }
}