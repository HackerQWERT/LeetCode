using System;

public class 轮转数组

{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        Array.Reverse(nums);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, nums.Length - k);
    }
}