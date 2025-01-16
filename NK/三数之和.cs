using System;
using System.Collections.Generic;

public class 三数之和
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        HashSet<(int, int, int)> resultSet = new HashSet<(int, int, int)>();
        IList<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2;)
        {
            if (nums[i] > 0)
            {
                break;
            }
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                if (nums[i] + nums[left] + nums[right] == 0)
                {
                    var triplet = (nums[i], nums[left], nums[right]);
                    if (!resultSet.Contains(triplet))
                    {
                        resultSet.Add(triplet);
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    }
                    while (true)
                    {
                        left++;
                        if (left >= right)
                            goto StopThisLoop;
                        if (nums[left] != nums[left - 1])
                            break;
                    }
                    while (true)
                    {
                        right--;
                        if (left >= right)
                            goto StopThisLoop;
                        if (nums[right] != nums[right + 1])
                            break;
                    }
                }
                else if (nums[i] + nums[left] + nums[right] < 0)
                {
                    while (true)
                    {
                        left++;
                        if (left >= right)
                            goto StopThisLoop;
                        if (nums[left] != nums[left - 1])
                            break;
                    }
                }
                else if (nums[i] + nums[left] + nums[right] > 0)
                {
                    while (true)
                    {
                        right--;
                        if (left >= right)
                            goto StopThisLoop;
                        if (nums[right] != nums[right + 1])
                            break;
                    }
                }
            }
        StopThisLoop:
            while (true)
            {
                i++;
                if (i >= nums.Length)
                    break;
                if (i < nums.Length && nums[i] != nums[i - 1])
                    break;
            }
        }
        return result;
    }
}