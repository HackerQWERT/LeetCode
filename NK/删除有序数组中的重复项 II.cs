using System;
using System.Data;

public class Solution1
{
    public int RemoveDuplicates(int[] nums)
    {

        int left = 0;
        int right = 0;
        int count = 1;
        while (true)
        {
            if (right > nums.Length - 1)
                break;
            //移动right记录当前数字的个数
            while (true)
            {
                if (right + 1 <= nums.Length - 1 && nums[right] == nums[right + 1])
                {
                    right++;
                    count++;
                }
                else
                {
                    right++;
                    break;
                }

            }
            count = Math.Min(count, 2);
            for (int i = 0; i < count; i++)
            {
                nums[left++] = nums[right - 1];
            }
            count = 1;
        }
        return left;

    }
}