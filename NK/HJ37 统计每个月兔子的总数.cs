// using System;
// using System.Collections.Generic;

// public class Program
// {
//     // 有一种兔子，从出生后第3个月起每个月都生一只兔子，小兔子长到第三个月后每个月又生一只兔子。
//     // 例子：假设一只兔子第3个月出生，那么它第5个月开始会每个月生一只兔子。
//     // 一月的时候有一只兔子，假如兔子都不死，问第n个月的兔子总数为多少？
//     public static void Main()
//     {
//         int n = int.Parse(Console.ReadLine());
//         //     List<int> ints = new List<int> { 1 };
//         //     ints[0] = 0;
//         //     for (int i = 1; i <= n; i++)
//         //     {
//         //         int index = 0;
//         //         while (index <= ints.Count - 1)
//         //         {
//         //             if (ints[index] >= 2)
//         //                 ints.Add(0);
//         //             ints[index]++;
//         //             index++;
//         //         }
//         //     }
//         //     System.Console.WriteLine(ints.Count);
//         // }
//         //大于等于两月的兔子数
//         int greaterTwo = 0;
//         //每月开始时一月的兔子数
//         int one = 0;
//         //每月开始时gang出生的兔子数
//         int zero = 0;
//         //每月开始新送进去的0月兔子数
//         int sentZero = 0;
//         //每月开始新送进去的1月兔子数
//         int sentOne = 0;
//         //每月开始新送进去的2月兔子数
//         int sentTwo = 0;
//         for (int i = 1; i <= n; i++)
//         {
//             if (i == 1)
//             {
//                 sentZero = 1;
//                 sentOne = 0;
//                 sentTwo = 0;
//             }
//             else
//             {
//                 sentZero = 0;
//                 sentOne = 0;
//                 sentTwo = 0;
//             }
//             //每月开始
//             zero = sentZero;
//             one += sentOne;
//             greaterTwo += sentTwo;
//             zero += greaterTwo;
//             //每月结束
//             greaterTwo += one;
//             one = zero;
//             zero = 0;
//         }
//         System.Console.WriteLine(one + zero + greaterTwo);


//     }
// }
