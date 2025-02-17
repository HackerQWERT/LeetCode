// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class LCR081组合总和
// {
//     public IList<IList<int>> CombinationSum(int[] candidates, int target)
//     {
//         IList<IList<int>>[] dp = new IList<IList<int>>[target + 1];
//         dp[0] = new List<IList<int>> { new List<int>() };
//         for (int i = 1; i <= target; i++)
//         {
//             foreach (int candidate in candidates)
//             {
//                 if (i - candidate >= 0 && dp[i - candidate] != null)
//                 {
//                     if (dp[i] == null)
//                     {
//                         dp[i] = new List<IList<int>>();
//                     }
//                     foreach (IList<int> list in dp[i - candidate])
//                     {
//                         if (list == null || candidate >= list.LastOrDefault())
//                         {
//                             IList<int> newList = new List<int>(list);
//                             newList.Add(candidate);
//                             dp[i].Add(newList);
//                         }

//                     }
//                 }
//             }
//         }
//         return dp[target] ?? new List<IList<int>>();
//         // //去重
//         // List<List<int>> res = new List<List<int>>();
//         // HashSet<string> set = new HashSet<string>();
//         // if (dp[target] == null)
//         // {
//         //     return res.ToArray();
//         // }
//         // foreach (var list in dp[target])
//         // {
//         //     var ls = list.OrderBy(x => x).ToList();
//         //     string str = string.Join(",", ls);
//         //     if (!set.Contains(str))
//         //     {
//         //         set.Add(str);
//         //         res.Add(ls);
//         //     }
//         // }
//         // return res.ToArray();


//         // return dp[target] ?? new List<IList<int>>();
//     }
// }