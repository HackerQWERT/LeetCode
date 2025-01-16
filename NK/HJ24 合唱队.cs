// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         // N 位同学站成一排，音乐老师要请最少的同学出列，使得剩下的 K 位同学排成合唱队形。
//         // K名同学排成了合唱队形。
//         // 通俗来说，能找到一个同学，他的两边的同学身高都依次严格降低的队形就是合唱队形。
//         // 例子：
//         // 123 124 125 123 121 是一个合唱队形
//         // 123 123 124 122不是合唱队形，因为前两名同学身高相等，不符合要求
//         // 123 122 121 122不是合唱队形，因为找不到一个同学，他的两侧同学身高递减。
//         // 你的任务是，已知所有N位同学的身高，计算最少需要几位同学出列，可以使得剩下的同学排成合唱队形。
//         int N = int.Parse(Console.ReadLine());
//         var heights = Console.ReadLine().Split().Select(int.Parse).ToArray();
//         int[] inc = new int[N];
//         int[] dec = new int[N];
//         // 计算每个位置的最长递增子序列长度
//         for (int i = 0; i < N; i++)
//         {
//             inc[i] = 1;
//             for (int j = 0; j < i; j++)
//             {
//                 if (heights[j] < heights[i])
//                 {
//                     inc[i] = Math.Max(inc[i], inc[j] + 1);
//                 }
//             }
//         }
//         // 计算每个位置的最长递减子序列长度
//         for (int i = N - 1; i >= 0; i--)
//         {
//             dec[i] = 1;
//             for (int j = N - 1; j > i; j--)
//             {
//                 if (heights[j] < heights[i])
//                 {
//                     dec[i] = Math.Max(dec[i], dec[j] + 1);
//                 }
//             }
//         }

//         // 计算最大合唱队形长度
//         int max = 0;
//         for (int i = 0; i < N; i++)
//         {
//             max = Math.Max(max, inc[i] + dec[i] - 1);
//         }

//         Console.WriteLine(N - max);
//     }
// }

