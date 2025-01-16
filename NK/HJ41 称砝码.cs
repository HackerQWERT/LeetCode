// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     //     现有n种砝码，重量互不相等，分别为 m1,m2,m3…mn ；
//     // 每种砝码对应的数量为 x1,x2,x3...xn 。现在要用这些砝码去称物体的重量(放在同一侧)，问能称出多少种不同的重量。

//     public static void Main()
//     {
//         int n = int.Parse(Console.ReadLine());
//         int[] weights = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//         int[] counts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//         int[] allWeights = new int[counts.Sum()];
//         //将所有weight存到allWeights
//         int index = 0;
//         for (int i = 0; i < weights.Count(); i++)
//         {
//             for (int j = 0; j < counts[i]; j++)
//             {
//                 allWeights[index++] = weights[i];
//             }
//         }
//         HashSet<int> currentWeights = new HashSet<int>();
//         currentWeights.Add(0);
//         for (int i = 0; i < allWeights.Count(); i++)
//         {
//             HashSet<int> newWeights = new HashSet<int>();
//             foreach (var weight in currentWeights)
//             {
//                 newWeights.Add(weight + allWeights[i]);
//                 newWeights.Add(weight);
//             }
//             currentWeights = newWeights;
//         }
//         Console.WriteLine(currentWeights.Count());

//     }

// }