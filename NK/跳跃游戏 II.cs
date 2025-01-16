using System.Collections.Generic;

public class 跳跃游戏II
{
    public int Jump(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 0;
        }

        int[] canJumpMaxIndex = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            canJumpMaxIndex[i] = nums[i] + i;
        }
        List<int> jumpIndexList = new List<int>();
        int index = canJumpMaxIndex.Length - 1;
        while (true)
        {
            for (int i = 0; i < canJumpMaxIndex.Length; i++)
            {
                if (canJumpMaxIndex[i] >= index)
                {
                    index = i;
                    jumpIndexList.Add(index);
                    break;
                }
            }
            if (index == 0)
            {
                break;
            }
        }
        return jumpIndexList.Count;

    }
}