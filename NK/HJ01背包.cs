// // using System;
// // using System.Collections.Generic;

// // public class Program
// // {
// //     record Good(int weight, int value);

// //     public static void Main()
// //     {
// //         int maxWeight = int.Parse(Console.ReadLine());
// //         int n = int.Parse(Console.ReadLine());
// //         Dictionary<int, Good> goodDict = new(); // 字典
// //         for (int i = 1; i <= n; i++)
// //         {
// //             string[] strs = Console.ReadLine().Split(' ');
// //             int weight = int.Parse(strs[0]);
// //             int value = int.Parse(strs[1]);
// //             goodDict.Add(i, new Good(weight, value));
// //         }
// //         int[,] ints = new int[n + 1, maxWeight + 1]; // 二维数组

// //         for (int i = 0; i <= n; i++)
// //         {
// //             var good = i == 0 ? null : goodDict[i];
// //             for (int j = 0; j <= maxWeight; j++)
// //             {
// //                 if (i == 0 || j == 0)
// //                     ints[i, j] = 0;
// //                 else
// //                 {
// //                     if (good.weight > j)
// //                         ints[i, j] = ints[i - 1, j];
// //                     else
// //                         ints[i, j] = Math.Max(ints[i, j - good.weight] + good.value, ints[i - 1, j]);
// //                 }
// //             }
// //         }
// //         Console.WriteLine(ints[n, maxWeight]);
// //     }
// // }

// using System;
// using System.Collections.Generic;

// public class Program
// {

//     public static void Main()
//     {
//         int goodCount = int.Parse(Console.ReadLine());
//         int[] weight = new int[goodCount + 1];
//         int[] value = new int[goodCount + 1];
//         int maxWeight = int.Parse(Console.ReadLine());
//         int[,] dp = new int[goodCount + 1, maxWeight + 1];
//         for (int i = 1; i <= goodCount; i++)
//         {
//             string[] strs = Console.ReadLine().Split(' ');
//             weight[i] = int.Parse(strs[0]);
//             value[i] = int.Parse(strs[1]);
//         }
//         for (int i = 1; i <= goodCount; i++)
//         {
//             for (int j = 1; j <= maxWeight; j++)
//             {
//                 if (j < weight[i])
//                 {
//                     dp[i, j] = dp[i - 1, j];
//                 }
//                 else
//                 {
//                     dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - weight[i]] + value[i]);
//                 }
//             }
//         }
//     }
// }