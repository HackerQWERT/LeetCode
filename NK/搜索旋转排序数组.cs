using System;

public class 搜索旋转排序数组
{
    // public static void Main(string[] args)
    // {
    //     int[] nums = [3, 1];
    //     int target = 1;
    //     Console.WriteLine(new Solution().Search(nums, target));
    //     Console.ReadLine();
    // }
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[left] <= nums[mid])
            {
                if (target < nums[mid] && target >= nums[left])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            else
            {
                if (target > nums[mid] && target <= nums[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }
        return -1;

    }
}