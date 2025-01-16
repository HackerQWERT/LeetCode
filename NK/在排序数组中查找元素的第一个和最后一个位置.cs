using System;

public class 在排序数组中查找元素的第一个和最后一个位置
{
    //     static void Main(string[] args)
    //     {
    //         Solution solution = new Solution();
    //         int[] nums = [1, 4];
    //         int target = 4;
    //         int[] result = solution.SearchRange(nums, target);
    //         foreach (var item in result)
    //         {
    //             Console.WriteLine(item);
    //         }
    //     }
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return new int[] { -1, -1 };
        }
        if (nums.Length == 1)
        {
            if (nums[0] == target)
            {
                return [0, 0];
            }
            else
            {
                return [-1, -1];
            }
        }
        var leftIndex = FindFirst(nums, target);
        if (leftIndex == -1)
        {
            return new int[] { -1, -1 };
        }
        var rightIndex = FindLast(nums, target);
        return new int[] { leftIndex, rightIndex };
    }

    private int FindLast(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (true)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] < target || nums[mid] == target)
            {

                left = mid + 1;
            }
            else if (nums[mid] > target)
            {
                right = mid;
            }
            if (left == right && nums[left] == target)
            {
                return left;
            }
            else if (left == right && nums[left - 1] == target)
            {
                return left - 1;
            }
            else if (left == right && nums[mid] != target)
            {
                return -1;
            }
        }
    }

    private int FindFirst(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (true)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else if (nums[mid] > target || nums[mid] == target)
            {
                right = mid;
            }
            if (left == right && nums[left] != target)
            {
                return -1;
            }
            else if (left == right && nums[left] == target)
            {
                return mid;
            }
        }
    }
}