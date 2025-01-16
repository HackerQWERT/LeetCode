// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         // 找出字符串中第一个只出现一次的字符
//         // 输出第一个只出现一次的字符，如果不存在输出-1
//         var chars = Console.ReadLine().ToArray();
//         Dictionary<char, int> charCount = new Dictionary<char, int>();
//         foreach (var c in chars)
//         {
//             if (charCount.ContainsKey(c))
//                 charCount[c]++;
//             else
//                 charCount[c] = 1;
//         }
//         foreach (var c in chars)
//         {
//             if (charCount[c] == 1)
//             {
//                 Console.WriteLine(c);
//                 return;
//             }
//         }

//         System.Console.WriteLine(-1);

//     }
// }