// using System;

// public class Program
// {
//     // 任意一个偶数（大于2）都可以由2个素数组成，组成偶数的2个素数有很多种情况，
//     // 本题目要求输出组成指定偶数的两个素数差值最小的素数对。

//     public static void Main()
//     {
//         int n = int.Parse(System.Console.ReadLine());
//         for (int i = n / 2; i >= 2; i--)
//         {
//             if (IsPrime(i) && IsPrime(n - i))
//             {
//                 System.Console.WriteLine(i);
//                 System.Console.WriteLine(n - i);
//                 break;
//             }
//         }
//     }

//     private static bool IsPrime(int num)
//     {
//         if (num <= 1) return false;
//         if (num == 2) return true;
//         if (num % 2 == 0) return false;
//         for (int i = 3; i * i <= num; i += 2)
//         {
//             if (num % i == 0) return false;
//         }
//         return true;
//     }
// }