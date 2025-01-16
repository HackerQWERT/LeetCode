// using System.ComponentModel;
// using System.Globalization;
// using System.Runtime.InteropServices;

// public class Program
// {
//     public static void Main()
//     {
//         // 蛇形矩阵是由1开始的自然数依次排列成的一个矩阵上三角形。

//         // 例如，当输入5时，应该输出的三角形为：

//         // 1 3 6 10 15

//         // 2 5 9 14

//         // 4 8 13

//         // 7 12

//         // 11
//         int n = System.Convert.ToInt32(System.Console.ReadLine());
//         int[,] matrix = new int[n, n];
//         int i = 0, j = 0;
//         int num = 1;
//         while (true)
//         {
//             matrix[i, j] = num++;
//             if (i == 0)
//             {
//                 i = j + 1;
//                 j = 0;
//             }
//             else
//             {
//                 i--;
//                 j++;
//             }
//             if (i == n)
//                 break;
//         }
//         for (i = 0; i < n; i++)
//         {
//             for (j = 0; j < n - i; j++)
//             {
//                 System.Console.Write(matrix[i, j]);
//                 if (j != n - i - 1)
//                     System.Console.Write(" ");
//             }
//             System.Console.WriteLine();
//         }
//     }
// }