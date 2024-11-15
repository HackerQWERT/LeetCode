Solution solution = new Solution();
int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
int[] nums2 = new int[] { 2, 5, 6 };
solution.Merge(nums1, 3, nums2, 3);

public class Solution
{

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {










        //循环打印Nums1
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine(nums1[i]);
        }
    }
}