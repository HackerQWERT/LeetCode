public class 寻找旋转排序数组中的最小值
{
    // static void Main()
    // {
    //     var solution = new Solution();
    //     var result = solution.FindMin([1, 2]);
    //     System.Console.WriteLine(result);
    // }

    public int FindMin(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (true)
        {
            if (nums[left] <= nums[right])
            {
                return nums[left];
            }
            if (left + 1 == right)
            {
                return nums[right];
            }
            int mid = (left + right) / 2;

            if (nums[left] <= nums[mid])
            {
                left = mid;
            }
            else
            {
                right = mid;
            }
        }
    }
}