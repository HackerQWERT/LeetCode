public class 买卖股票的最佳时机II
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 0; i <= prices.Length - 2; i++)
            if (prices[i + 1] > prices[i])
                maxProfit += prices[i + 1] - prices[i];
        return maxProfit;
    }
}