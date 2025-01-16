using System;

public class 除自身以外数组的乘积
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];
        Array.Fill(result, 1);
        int left = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] *= left;
            left *= nums[i];
        }
        int right = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= right;
            right *= nums[i];
        }
        return result;
    }
}