using System;

public class 跳跃游戏
{
    public bool CanJump(int[] nums)
    {
        int maxIndex = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (maxIndex < i)
            {
                return false;
            }
            maxIndex = Math.Max(maxIndex, i + nums[i]);
            if (maxIndex >= nums.Length - 1)
            {
                return true;
            }
        }
        return false;
    }
}