public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int fastIndex = 1;
        int slowIndex = 0;
        while (fastIndex < nums.Length)
        {
            if (nums[fastIndex] != nums[slowIndex])
            {
                nums[++slowIndex] = nums[fastIndex];
            }
            fastIndex++;
        }
        return slowIndex + 1;

    }
}