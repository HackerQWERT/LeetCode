// using System;
// using System.Collections.Generic;
// using System.Text;

// public class Program
// {
//     public static void Main()
//     {
//         int N = int.Parse(Console.ReadLine());
//         StringBuilder stringBuilder = new StringBuilder();
//         for (int i = 2; i * i <= N; i++)
//         {
//             while (N % i == 0)
//             {
//                 stringBuilder.Append(i + " ");
//                 N = N / i;
//             }
//         }
//         //1不能拿，最后等于1说明质数已经拿完
//         if (N > 1)
//         {
//             stringBuilder.Append(N + " ");
//         }
//         Console.WriteLine(
//             stringBuilder.ToString().Trim()
//         );





//     }
// }