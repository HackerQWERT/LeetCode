// using System;

// public class Program
// {
//     public static void Main()
//     {
//         // 正整数A和正整数B 的最小公倍数是指 能被A和B整除的最小的正整数值，设计一个算法，求输入A和B的最小公倍数。
//         var tokens = Console.ReadLine().Split(' ');
//         var a = int.Parse(tokens[0]);
//         var b = int.Parse(tokens[1]);
//         Console.WriteLine(LCM(a, b));
//     }

//     private static int LCM(int a, int b)
//     {
//         //乘数
//         int i = 1;
//         while (true)
//         {
//             if (a * i++ % b == 0)
//             {
//                 return a * (i - 1);
//             }
//         }

//     }
// }