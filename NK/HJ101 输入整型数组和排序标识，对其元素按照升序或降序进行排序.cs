// using System;
// using System.Linq;

// public class Program
// {
//     //     第一行输入数组元素个数
//     // 第二行输入待排序的数组，每个数用空格隔开
//     // 第三行输入一个整数0或1。0代表升序排序，1代表降序排序
//     public static void Main()
//     {
//         int n = int.Parse(Console.ReadLine());
//         int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
//         int order = int.Parse(Console.ReadLine());
//         if (order == 0)
//             arr.OrderBy(x => x).ToList().ForEach(x => System.Console.Write(x + " "));
//         else
//             arr.OrderByDescending(x => x).ToList().ForEach(x => System.Console.Write(x + " "));
//     }
// }