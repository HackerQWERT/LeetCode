Solution solution = new Solution();
int[] nums1 = new int[] { 4, 5, 6, 0, 0, 0 };
int[] nums2 = new int[] { 1, 2, 3 };
solution.Merge(nums1, 3, nums2, 3);

public class Solution
{

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int index1 = m - 1;
        int index2 = n - 1;
        int index = m + n - 1;

        while (index1 >= 0 && index2 >= 0)
        {
            if (nums1[index1] >= nums2[index2])
                nums1[index--] = nums1[index1--];
            else
                nums1[index--] = nums2[index2--];
        }
        while (index2 >= 0)
            nums1[index--] = nums2[index2--];
        //TODO: Uncomment the following code to print the result
        // foreach (int i in nums1)
        //     Console.Write(i);

    }
}