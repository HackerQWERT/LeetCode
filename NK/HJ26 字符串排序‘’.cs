// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         // 编写一个程序，将输入字符串中的字符按如下规则排序。
//         // 规则 1 ：英文字母从 A 到 Z 排列，不区分大小写。
//         // 如，输入： Type 输出： epTy
//         // 规则 2 ：同一个英文字母的大小写同时存在时，按照输入顺序排列。
//         // 如，输入： BabA 输出： aABb
//         // 规则 3 ：非英文字母的其它字符保持原来的位置。
//         // 如，输入： By?e 输出： Be?y
//         // 数据范围：输入的字符串长度满足 
//         string line = Console.ReadLine();
//         char[] chars = line.ToCharArray();
//         char[] result = new char[chars.Length];
//         List<char> letters = new List<char>();
//         for (int i = 0; i < chars.Length; i++)
//         {
//             if (!char.IsLetter(chars[i]))
//                 result[i] = chars[i];
//             else
//                 letters.Add(chars[i]);
//         }
//         letters = letters.OrderBy(c => char.ToLower(c)).ToList();
//         // .Sort((a, b) => char.ToLower(a).CompareTo(char.ToLower(b)));
//         //如果result没有被赋值，那么就是字母字符，直接赋值
//         int lettersIndex = 0;
//         for (int i = 0; i < result.Length; i++)
//         {
//             if (result[i] == '\0')
//                 result[i] = letters[lettersIndex++];
//         }
//         System.Console.WriteLine(result);
//     }
// }