
public class 寻找峰值
{
    public int FindPeakElement(int[] nums)
    {

        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] < nums[mid + 1])
                left = mid + 1;
            else
                right = mid;
        }

        return left;                                         // return left or right    

    }
}