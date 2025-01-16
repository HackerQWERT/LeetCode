// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         // 完全数（Perfect number），又称完美数或完备数，是一些特殊的自然数。
//         // 它所有的真因子（即除了自身以外的约数）的和（即因子函数），恰好等于它本身。
//         // 例如：28，它有约数1、2、4、7、14、28，除去它本身28外，其余5个数相加，1+2+4+7+14=28。
//         // 输入n，请输出n以内(含n)完全数的个数。
//         int n = Convert.ToInt32(Console.ReadLine());
//         List<int> perfectNumbers = new List<int>();
//         for (int i = 1; i <= n; i++)
//         {
//             if (IsPerfectNumber(i))
//                 perfectNumbers.Add(i);
//         }
//         Console.WriteLine(perfectNumbers.Count);
//     }
//     static bool IsPerfectNumber(int n)
//     {
//         List<int> factors = new List<int>();
//         for (int i = 1; i <= n / 2; i++)
//         {
//             if (n % i == 0)
//                 factors.Add(i);
//         }
//         return factors.Sum() == n;

//     }

// }