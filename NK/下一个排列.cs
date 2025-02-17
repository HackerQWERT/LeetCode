using System;

public class 下一个排列
{

    public void NextPermutation(int[] nums)
    {
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] < nums[i + 1])
            {
                for (int j = nums.Length - 1; j > i; j--)
                {
                    if (nums[j] > nums[i])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        Array.Reverse(nums, i + 1, nums.Length - i - 1);
                        // Array.Sort(nums, i + 1, nums.Length - i - 1);
                        return;
                    }
                }
            }
        }
        Array.Reverse(nums);
        return;
    }
}