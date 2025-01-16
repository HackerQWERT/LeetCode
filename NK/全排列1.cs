using System.Collections.Generic;
using System.Linq;

public class 全排列
{
    List<IList<int>> result = new List<IList<int>>();

    public IList<IList<int>> Permute(int[] nums)
    {
        DFS(nums.ToList(), new List<int>());
        return result;
    }

    private void DFS(List<int> nums, List<int> list)
    {
        if (nums.Count == 0)
        {
            result.Add(new List<int>(list));
            return;
        }
        for (int i = 0; i < nums.Count; i++)
        {
            List<int> newList = new List<int>(list);
            newList.Add(nums[i]);
            List<int> newNums = new List<int>(nums);
            newNums.RemoveAt(i);
            DFS(newNums, newList);
        }
    }
}