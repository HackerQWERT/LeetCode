// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     // 以上三角形的数阵，第一行只有一个数1，以下每行的每个数，
//     // 是恰好是它上面的数、左上角数和右上角的数，3个数之和（如果不存在某个数，认为该数就是0）。

//     // 求第n行第一个偶数出现的位置。如果没有偶数，则输出-1。例如输入3,则输出2，输入4则输出3，输入2则输出-1。
//     // 输入一个int整数
//     // 输出返回的int值
//     public static void Main()
//     {
//         int n = int.Parse(Console.ReadLine());
//         if (n <= 2)
//         {
//             Console.WriteLine(-1);
//             return;
//         }

//         int[] positions = { 2, 3, 2, 4 };
//         Console.WriteLine(positions[(n - 3) % 4]);
//     }
// }


// // Main()
// //     {
// //         int n = int.Parse(Console.ReadLine());
// //         if (n == 1)
// //         {
// //             Console.WriteLine(-1);
// //             return;
// //         }

// //         List<int> lastRow = new List<int> { 1 };
// //         List<int> currentRow = Enumerable.Repeat(0, lastRow.Count + 2).ToList();

// //         // 时间复杂度: O(n^2)
// //         for (int i = 2; i <= n; i++)
// //         {
// //             for (int j = 0; j < currentRow.Count; j++)
// //             {
// //                 currentRow[j] = (j - 2 < 0 ? 0 : lastRow[j - 2]) +
// //                                 (j - 1 < 0 || j - 1 > lastRow.Count - 1 ? 0 : lastRow[j - 1]) +
// //                                 (j > lastRow.Count - 1 ? 0 : lastRow[j]);
// //             }

// //             lastRow = new List<int>(currentRow);
// //             currentRow = Enumerable.Repeat(0, lastRow.Count + 2).ToList();
// //         }

// //         // 时间复杂度: O(n)
// //         for (int i = 0; i < lastRow.Count; i++)
// //         {
// //             if (lastRow[i] % 2 == 0)
// //             {
// //                 Console.WriteLine(i + 1);
// //                 return;
// //             }
// //         }

// //         Console.WriteLine(-1);
// //     }

