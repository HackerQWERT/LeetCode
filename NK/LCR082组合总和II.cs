// using System.Collections.Generic;
// using System.Linq;

// public class Solution
// {
//     static void Main()
//     {
//         int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
//         int target = 8;
//         IList<IList<int>> result = new Solution().CombinationSum2(candidates, target);
//         foreach (IList<int> list in result)
//         {
//             foreach (int num in list)
//             {
//                 System.Console.Write(num + " ");
//             }
//             System.Console.WriteLine();
//         }
//     }
//     public IList<IList<int>> CombinationSum2(int[] candidates, int target)
//     {
//         candidates = candidates.OrderBy(x => x).ToArray();
//         List<IList<int>>[] dp = new List<IList<int>>[target + 1];
//         HashSet<string>[] dpSet = new HashSet<string>[target + 1];
//         dp[0] = new List<IList<int>> { new List<int>() };
//         foreach (int candidate in candidates)
//         {
//             for (int i = target; i >= candidate; i--)
//             {
//                 if (dp[i - candidate] == null)
//                 {
//                     continue;
//                 }
//                 else if (dp[i - candidate] != null)
//                 {
//                     if (dpSet[i] == null)
//                     {
//                         dpSet[i] = new HashSet<string>();
//                     }
//                     if (dp[i] == null)
//                     {
//                         dp[i] = new List<IList<int>>();
//                     }
//                     foreach (List<int> list in dp[i - candidate])
//                     {
//                         if (list.Count > 0 && candidate < list.LastOrDefault())
//                         {
//                             continue;
//                         }
//                         List<int> newList = new List<int>(list);
//                         newList.Add(candidate);
//                         string newString = string.Join(",", newList);
//                         if (!dpSet[i].Contains(newString))
//                         {
//                             dpSet[i].Add(newString);
//                             dp[i].Add(newList);
//                         }
//                     }
//                 }
//             }
//         }

//         return dp[target] ?? new List<IList<int>>();

//     }
// }
using System;
using System.Collections.Generic;
using System.Linq;

public class LCR082组合总和II
{
    private List<IList<int>> result = new List<IList<int>>();
    private int target;
    private int sum;
    private LinkedList<int> currentList = new LinkedList<int>();
    private HashSet<string> resultSet = new HashSet<string>();
    private int[] candidates;

    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        this.target = target;
        this.result = new List<IList<int>>();
        this.sum = 0;
        this.candidates = candidates.OrderBy(x => x).ToArray();
        DFS(0);
        return result;
    }

    private void DFS(int start = 0)
    {
        //去重
        HashSet<int> set = new HashSet<int>();
        //遍历每一个候选数字
        for (int i = start; i < candidates.Length; i++)
        {
            //去重
            if (set.Contains(candidates[i]))
                continue;
            set.Add(candidates[i]);
            int candidate = candidates[i];

            sum += candidate;
            currentList.AddLast(candidate);
            //找到一个解
            if (sum == target)
            {
                string key = string.Join(",", currentList);
                if (!resultSet.Contains(key))
                {
                    resultSet.Add(key);
                    result.Add(new List<int>(currentList));
                }
            }
            //剪枝
            else if (sum > target)
            {
                sum -= candidate;
                currentList.RemoveLast();
                return;
            }
            //继续深搜
            DFS(i + 1);
            //回溯
            sum -= candidate;
            currentList.RemoveLast();
        }
    }
}