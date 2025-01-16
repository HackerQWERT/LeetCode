// using System;
// using System.Collections.Generic;

// public class Program
// {
//     // 若两个正整数的和为素数，则这两个正整数称之为“素数伴侣”，如2和5、6和13，它们能应用于通信加密。
//     // 现在密码学会请你设计一个程序，从已有的 N （ N 为偶数）个正整数中挑选出若干对组成“素数伴侣”，挑选方案多种多样，
//     // 例如有4个正整数：2，5，6，13，如果将5和6分为一组中只能得到一组“素数伴侣”，
//     // 而将2和5、6和13编组将得到两组“素数伴侣”，能组成“素数伴侣”最多的方案称为“最佳方案”，当然密码学会希望你寻找出“最佳方案”。
//     public static void Main()
//     {
//         int n = int.Parse(Console.ReadLine());
//         int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//         List<int> evens = new List<int>();
//         List<int> odds = new List<int>();

//         // 将输入的数字分为奇数和偶数两组
//         foreach (int num in nums)
//         {
//             if (num % 2 == 0)
//                 evens.Add(num);
//             else
//                 odds.Add(num);
//         }

//         // 初始化匹配数组，-1表示未匹配
//         int[] match = new int[odds.Count];
//         Array.Fill(match, -1);
//         int result = 0;

//         // 尝试为每个偶数找到匹配的奇数
//         foreach (int even in evens)
//         {
//             bool[] visited = new bool[odds.Count];
//             if (FindMatch(even, odds, match, visited))
//                 result++;
//         }

//         Console.WriteLine(result);
//     }

//     // 判断两个数的和是否为素数
//     private static bool IsPrime(int num)
//     {
//         if (num < 2) return false;
//         for (int i = 2; i * i <= num; i++)
//         {
//             if (num % i == 0) return false;
//         }
//         return true;
//     }

//     // 尝试为当前的偶数找到匹配的奇数
//     private static bool FindMatch(int even, List<int> odds, int[] match, bool[] visited)
//     {
//         for (int i = 0; i < odds.Count; i++)
//         {
//             if (IsPrime(even + odds[i]) && !visited[i])
//             {
//                 visited[i] = true;
//                 if (match[i] == -1 || FindMatch(match[i], odds, match, visited))
//                 {
//                     match[i] = even;
//                     return true;
//                 }
//             }
//         }
//         return false;
//     }
// }