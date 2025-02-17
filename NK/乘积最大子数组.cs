
// public class Solution
// {
//     public int MaxProduct(int[] nums)
//     {
//         long[] dp = new long[nums.Length];
//         dp[0] = nums[0];

//         for (int i = 1; i < nums.Length; i++)
//         {
//             if (dp[i - 1] == 0)
//             {
//                 dp[i] = nums[i];
//             }
//             else
//             {
//                 dp[i] = dp[i - 1] * nums[i];
//             }
//         }
//         int lastZeroIndex = -1;
//         long max = long.MinValue;
//         for (int i = 0; i < nums.Length; i++)
//         {
//             if (nums[i] == 0)
//             {
//                 lastZeroIndex = i;
//             }
//             if (dp[i] < 0)
//             {
//                 for (int j = lastZeroIndex + 1; j <= i; j++)
//                 {
//                     dp[i] = dp[i] / nums[j];
//                     if (j == i)
//                     {
//                         dp[i] = nums[i];
//                         break;
//                     }
//                     if (nums[j] < 0)
//                     {
//                         break;
//                     }
//                 }
//             }
//             max = Math.Max(max, dp[i]);
//         }
//         return (int)max;
//     }
// }

using System;

public class 乘积最大子数组
{
    public int MaxProduct(int[] nums)
    {
        int max = nums[0];
        int min = nums[0];
        int result = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            var tempMax = Math.Max(Math.Max(max * nums[i], min * nums[i]), nums[i]);
            var tempMin = Math.Min(Math.Min(max * nums[i], min * nums[i]), nums[i]);
            max = tempMax;
            min = tempMin;
            result = Math.Max(result, max);
        }
        return result;
    }
}