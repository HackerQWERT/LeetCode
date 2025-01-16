using System;
using System.Collections.Generic;
using System.Linq;

public class 最长连续序列
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        HashSet<int> set = new HashSet<int>(nums);
        int max = 1;

        foreach (var num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int maxCount = 1;
                while (true)
                {
                    if (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        maxCount++;
                    }
                    else
                    {
                        max = Math.Max(max, maxCount);
                        break;
                    }

                }
            }
        }
        return max;
    }

}