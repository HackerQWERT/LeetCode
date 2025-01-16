// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         var s = Console.ReadLine().Split(' ');
//         int n = int.Parse(s[0]);
//         int m = int.Parse(s[1]);
//         int[,] arr = new int[n, m];
//         for (int i = 0; i < n; i++)
//         {
//             string[] strs = Console.ReadLine().Split(' ');
//             for (int j = 0; j < m; j++)
//             {
//                 arr[i, j] = int.Parse(strs[j]);
//             }
//         }
//         List<Dictionary<int, int>> dictList = new List<Dictionary<int, int>>();
//         //将二维素组每一列转换为对应数量的字典
//         for (int i = 0; i < m; i++)
//         {
//             Dictionary<int, int> dict = new Dictionary<int, int>();
//             for (int j = 0; j < n; j++)
//             {
//                 dict[arr[j, i]] = dict.ContainsKey(arr[j, i]) ? dict[arr[j, i]] + 1 : 1;
//             }
//             dictList.Add(dict);
//         }
//         int k = int.Parse(Console.ReadLine());
//         int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//         Dictionary<int, int> targetDict = new Dictionary<int, int>();
//         //将目标数组转换为字典
//         for (int i = 0; i < k; i++)
//             targetDict[arr1[i]] = targetDict.ContainsKey(arr1[i]) ? targetDict[arr1[i]] + 1 : 1;
//         Dictionary<int, int> windowDict = new Dictionary<int, int>();
//         //滑动窗口遍历dictLiat，找到包含targetDict的最小窗口的索引差值
//         int left = 0;
//         int right = 0;
//         int minLen = int.MaxValue;
//         //初始化窗口
//         windowDict = dictList[0].ToDictionary(x => x.Key, x => x.Value);
//         if (Check(windowDict, targetDict))
//         {
//             System.Console.WriteLine(1);
//             return;
//         }
//         while (true)
//         {
//             right++;
//             if (right < dictList.Count)
//                 foreach (var key in dictList[right].Keys)
//                     windowDict[key] = windowDict.ContainsKey(key) ? windowDict[key] + dictList[right][key] : dictList[right][key];
//             while (Check(windowDict, targetDict))
//             {
//                 minLen = Math.Min(minLen, right - left + 1);
//                 foreach (var key in dictList[left].Keys)
//                     windowDict[key] -= dictList[left][key];
//                 left++;
//             }
//             if (right == dictList.Count)
//                 break;
//         }
//         if (minLen == int.MaxValue)
//             System.Console.WriteLine(-1);
//         else
//             System.Console.WriteLine(minLen);
//     }

//     private static bool Check(Dictionary<int, int> windowDict, Dictionary<int, int> targetDict)
//     {
//         foreach (var key in targetDict.Keys)
//         {
//             if (!windowDict.ContainsKey(key) || windowDict[key] < targetDict[key])
//                 return false;
//         }
//         return true;
//     }
// }
