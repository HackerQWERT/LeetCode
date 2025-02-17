using System;
using System.Collections.Generic;

public class 缺失的第一个正数
{

    public static int FirstMissingPositive(int[] nums)
    {

        for (int i = 0; i < nums.Length; i++)
            while (nums[i] > 0 && nums[i] < nums.Length && nums[nums[i] - 1] != nums[i])
            {
                int temp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = temp;
            }

        for (int i = 0; i < nums.Length; i++)
            if (nums[i] != i + 1)
                return i + 1;
        return nums.Length + 1;
    }
}