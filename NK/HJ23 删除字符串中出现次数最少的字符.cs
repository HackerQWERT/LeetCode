// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         // 实现删除字符串中出现次数最少的字符，若出现次数最少的字符有多个，
//         // 则把出现次数最少的字符都删除。输出删除这些单词后的字符串，字符串中其它字符保持原来的顺序。
//         string line = Console.ReadLine();
//         Dictionary<char, int> dict = new Dictionary<char, int>();
//         foreach (char c in line)
//             if (dict.ContainsKey(c))
//                 dict[c]++;
//             else
//                 dict[c] = 1;
//         int min = dict.Values.Min();
//         foreach (char c in line)
//             if (dict[c] != min)
//                 Console.Write(c);

//     }
// }