// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class 前K个高频元素

// {
//     Dictionary<int, int> dic = new Dictionary<int, int>();

//     public int[] TopKFrequent(int[] nums, int k)
//     {
//         foreach (var num in nums)
//         {
//             if (dic.ContainsKey(num))
//                 dic[num]++;
//             else
//                 dic[num] = 1;
//         }
//         //长度为nums.Length+1
//         // List<int>[] arr = new List<int>[nums.Length + 1];
//         // foreach (var pair in dic)
//         // {
//         //     if (arr[pair.Value] == null)
//         //         arr[pair.Value] = new List<int>();
//         //     arr[pair.Value].Add(pair.Key);
//         // }
//         // List<int> list = new List<int>();
//         // for (int i = arr.Length - 1; i >= 0 && list.Count < k; i--)
//         // {
//         //     if (arr[i] != null)
//         //         list.AddRange(arr[i]);
//         //     if (list.Count > k)
//         //         return list.Take(k).ToArray();
//         // }
//         // return list.ToArray();


//         // Dictionary<int, List<int>> dic1 = new();
//         // foreach (var pair in dic)
//         // {
//         //     if (dic1.ContainsKey(pair.Value))
//         //         dic1[pair.Value].Add(pair.Key);
//         //     else
//         //         dic1[pair.Value] = new List<int> { pair.Key };
//         // }
//         // List<int> list = dic1.Keys.OrderByDescending(x => x).ToList();
//         // List<int> res = new List<int>();
//         // foreach (var key in list)
//         // {
//         //     res.AddRange(dic1[key]);
//         //     if (res.Count >= k)
//         //         break;
//         // }
//         // return res.Take(k).ToArray();
//         // return list.SelectMany(x => dic1[x]).Take(k).ToArray();

//         List<int> list = new List<int>();
//         foreach (var pair in dic)
//         {
//             list.Add(pair.Key);
//         }
//         list.Sort((a, b) => dic[b] - dic[a]);
//         return list.Take(k).ToArray();
//     }
// }