using System;
using System.Linq;

public class 半径为k的子数组平均值
{
    public int[] GetAverages(int[] nums, int k)
    {
        if (k > nums.Length / 2)
        {
            int[] r = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                r[i] = -1;
            }
            return r;
        }
        int[] res = new int[nums.Length];
        //先取出前k个数和后k个数，赋值为-1
        for (int i = 0; i < k; i++)
        {
            res[i] = -1;
        }
        for (int i = nums.Length - k; i < nums.Length; i++)
        {
            res[i] = -1;
        }
        for (int i = k; i < nums.Length - k; i++)
        {
            // long sum1 = 0;
            // for (int j = i - k; j <= i; j++)
            // {
            //     sum1 += nums[j];
            // }
            // long sum2 = 0;
            // for (int j = i + 1; j <= i + k; j++)
            // {
            //     sum2 += nums[j];
            // }
            // double sum = sum1 + sum2;
            // res[i] = (int)(sum / (2 * k + 1));
            long sum = 0;
            for (int j = i - k; j <= i + k; j++)
            {
                sum += nums[j];
            }
            res[i] = (int)(sum / (2 * k + 1));

        }
        return res;
    }
}