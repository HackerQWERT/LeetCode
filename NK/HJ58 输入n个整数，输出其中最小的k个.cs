// using System;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         // 输入n个整数，找出其中最小的k个整数并按升序输出
//         // 本题有多组输入样例
//         var tokens = Console.ReadLine().Split(' ');
//         int n = int.Parse(tokens[0]);
//         int k = int.Parse(tokens[1]);
//         var numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).OrderBy(x => x).ToArray();
//         for (int i = 0; i < k; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     }
// }