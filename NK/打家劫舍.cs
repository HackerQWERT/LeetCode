using System;
using System.Linq;

public class 打家劫舍
{
    public int Rob(int[] nums)
    {

        int[] dp = new int[nums.Length];
        if (nums.Length == 0)
        {
            return 0;
        }
        if (nums.Length == 1)
        {
            return nums[0];
        }
        if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++)
        {
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
        }
        return dp[nums.Length - 1];
    }
}